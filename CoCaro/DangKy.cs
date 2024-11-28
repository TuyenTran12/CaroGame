using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CoCaro
{
    public partial class DangKy : Form
    {
        private readonly DatabaseConnection database;
        private SqlConnection conn;

        public DangKy()
        {
            InitializeComponent();
            database = new DatabaseConnection();
        }

        private void btnDangKy_Click_1(object sender, EventArgs e)
        {
            string username = txtTaiKhoan.Text.Trim();
            string password = txtMatKhau.Text.Trim();
            string confirmPassword = txtXacNhanMatKhau.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (username.Length <= 5)
            {
                MessageBox.Show("Tên tài khoản phải dài hơn 5 ký tự.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (password.Length < 8)
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 8 ký tự.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                conn = database.OpenConnection();

                // Kiểm tra xem tài khoản đã tồn tại chưa
                string checkQuery = "SELECT COUNT(*) FROM Login WHERE username = @username";
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@username", username);
                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (count > 0)
                    {
                        MessageBox.Show("Tên tài khoản đã tồn tại, vui lòng chọn tài khoản khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        // Thêm tài khoản mới vào cơ sở dữ liệu
                        string insertQuery = "INSERT INTO Login (username, password) VALUES (@username, @password)";
                        using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                        {
                            insertCmd.Parameters.AddWithValue("@username", username);
                            insertCmd.Parameters.AddWithValue("@password", password);

                            int result = insertCmd.ExecuteNonQuery();

                            if (result > 0)
                            {
                                MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                DangNhap dn = new DangNhap();
                                dn.Show();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Đăng ký thất bại, vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                database.CloseConnection(conn);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DangNhap dn = new DangNhap();
            dn.Show();
            this.Hide();
        }

        private void lbDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap dn = new DangNhap();
            dn.Show();
            this.Hide();
        }
    }
}
