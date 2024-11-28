using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoCaro
{
    public partial class FormChangePassword : Form
    {
        private readonly DatabaseConnection database;
        private SqlConnection conn;
        public FormChangePassword()
        {
            InitializeComponent();
        }
        public string Username { get; set; }

        public FormChangePassword(string username)
        {
            InitializeComponent();
            database = new DatabaseConnection();
            Username = username;
        }
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string oldPassword = tbOldPassword.Text.Trim();
            string newPassword = tbNewPassword.Text.Trim();
            string confirmPassword = tbXacNhan.Text.Trim();

            if (string.IsNullOrEmpty(oldPassword) || string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPassword.Length < 8)
            {
                MessageBox.Show("Mật khẩu mới phải có ít nhất 8 ký tự.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                conn = database.OpenConnection();

                // Kiểm tra mật khẩu cũ
                string checkQuery = "SELECT COUNT(*) FROM Login WHERE username = @username AND password = @oldPassword";
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@username", Username);
                    checkCmd.Parameters.AddWithValue("@oldPassword", oldPassword);
                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (count == 0)
                    {
                        MessageBox.Show("Mật khẩu cũ không chính xác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Cập nhật mật khẩu mới
                string updateQuery = "UPDATE Login SET password = @newPassword WHERE username = @username";
                using (SqlCommand updateCmd = new SqlCommand(updateQuery, conn))
                {
                    updateCmd.Parameters.AddWithValue("@username", Username);
                    updateCmd.Parameters.AddWithValue("@newPassword", newPassword);

                    int result = updateCmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DangNhap dn = new DangNhap();
                        dn.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Đổi mật khẩu thất bại, vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
