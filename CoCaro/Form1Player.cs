using System;
using System.Web;
using System.Windows.Forms;

namespace CoCaro
{
    public partial class Form1Player : Form
    {
        public Form1Player()
        {
            InitializeComponent();
        }
        public Form1Player(string username)
        {
            InitializeComponent();
            txtPlayer.Text = username;
        }
        public int SoTran()
        {
            int soTran = 0;
            if (chk_3tran.Checked)
            {
                soTran += 3;
            }
            if (chk_5tran.Checked)
            {
                soTran += 5;
            }
            if (chk_7tran.Checked)
            {
                soTran += 7;
            }
            if (chk_10tran.Checked)
            {
                soTran += 10;
            }
            return soTran;
        }
        private void btnPlay_Click(object sender, EventArgs e)
        {
            String mt = "Máy tính";
            if (txtPlayer.Text == "Máy tính")
            {
                errorMessage("Bạn không được đặt tên này!");
                return;
            }
            if (cbbLevel.SelectedItem == null)
            {
                errorMessage("Bạn chưa chọn cấp độ!");
                return;
            }
            int level;
            if (cbbLevel.SelectedItem.ToString() == "Level 1")
                level = 1;
            else if (cbbLevel.SelectedItem.ToString() == "Level 2")
                level = 2;
            else if (cbbLevel.SelectedItem.ToString() == "Level 3")
                level = 3;
            else if (cbbLevel.SelectedItem.ToString() == "Level 4")
                level = 4;
            else
                level = 5;

            // Xác định người chơi nào đi trước
            string firstPlayer = rdb_1.Checked ? txtPlayer.Text : mt;
            string secondPlayer = rdb_1.Checked ? mt : txtPlayer.Text;
            FormGame formGame = new FormGame(firstPlayer, secondPlayer, 1, level,SoTran());

            formGame.ShowDialog();
            this.Close();
        }
        private void errorMessage(string text)
        {
            MessageBox.Show(text, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
