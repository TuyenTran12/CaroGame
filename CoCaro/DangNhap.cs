using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace CoCaro
{
    public partial class DangNhap : Form
    {
        private readonly DatabaseConnection database;
        private SQLiteConnection conn;

        public DangNhap()
        {
            InitializeComponent();
            database = new DatabaseConnection();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtTaiKhoan.Text.Trim();
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

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
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
    }
}
