using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CoCaro
{
    public partial class DangNhap : Form
    {
        private readonly DatabaseConnection database;
        private SqlConnection conn;

        public string username;
        public DangNhap()
        {
            InitializeComponent();
            database = new DatabaseConnection();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            username = txtTaiKhoan.Text.Trim();
            string password = txtMatKhau.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập tài khoản và mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                conn = database.OpenConnection();
                string query = "SELECT * FROM Login WHERE username = @username AND password = @password";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);


                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dtable = new DataTable();
                        adapter.Fill(dtable);

                        if (dtable.Rows.Count > 0)
                        {
                            FormStart frmStr = new FormStart();
                            frmStr.SetUserName(username);

                            frmStr.Show();

                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Thông tin đăng nhập không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_guest_Click_1(object sender, EventArgs e)
        {
            FormStart frmStr = new FormStart();
            frmStr.SetUserName("Khách"); // Đặt tên người dùng là "Khách"
            frmStr.DisableLeaderboard(); // Vô hiệu hóa chức năng Leaderboard
            frmStr.SetScore(0); // Đặt điểm số ban đầu là 0
            frmStr.Show();
            this.Hide();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            DangKy dk = new DangKy();
            dk.Show();
            this.Hide();
        }
    }
}
