using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration; // Đảm bảo bạn đã thêm using này để đọc App.config
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

            // Kiểm tra thông tin tài khoản và mật khẩu nhập vào
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập tài khoản và mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra nếu người dùng đăng nhập bằng tài khoản "guest"
            string guestUsername = ConfigurationManager.AppSettings["username"];
            string guestPassword = ConfigurationManager.AppSettings["password"];

            if (username == guestUsername && password == guestPassword)
            {
                // Nếu là guest, tự động đăng nhập và mở FormStart
                FormStart frmStr = new FormStart();
                frmStr.SetUserName(username);
                frmStr.Show();
                this.Hide();
            }
            else
            {
                // Nếu không phải guest, kiểm tra thông tin đăng nhập từ cơ sở dữ liệu
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
                                // Nếu tài khoản và mật khẩu hợp lệ, chuyển đến FormStart
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangKy dk = new DangKy();
            dk.Show();
            this.Hide();
        }

<<<<<<< HEAD
        private void btn_guest_Click(object sender, EventArgs e)
        {
            FormStart frmStr = new FormStart();
            frmStr.SetUserName("Khách"); // Đặt tên người dùng là "Khách"
            frmStr.DisableLeaderboard(); // Vô hiệu hóa chức năng Leaderboard
            frmStr.SetScore(0); // Đặt điểm số ban đầu là 0
            frmStr.Show();
            this.Hide();
=======
        private void btnGuest_Click(object sender, EventArgs e)
        {
            // Tự động đăng nhập với tài khoản "guest"
            txtTaiKhoan.Text = ConfigurationManager.AppSettings["username"];
            txtMatKhau.Text = ConfigurationManager.AppSettings["password"];
            btnDangNhap_Click(sender, e);  // Gọi lại hàm đăng nhập
>>>>>>> 8f6ca376bd09b0f4b318b584bff6f9efad7bf15c
        }
    }
}
