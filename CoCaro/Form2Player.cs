using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoCaro
{
    public partial class Form2Player : Form
    {
        public Form2Player()
        {
            InitializeComponent();
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
            if (txtPlayer1.Text == "")
            {
                errorMessage("Người chơi 1 chưa nhập tên!");
                return;
            }
            if (txtPlayer2.Text == "")
            {
                errorMessage("Người chơi 2 chưa nhập tên!");
                return;
            }
            if (txtPlayer1.Text == txtPlayer2.Text)
            {
                errorMessage("Tên hai người chơi không được trùng nhau!");
                return;
            }

            // Xác định người chơi nào đi trước
            string firstPlayer = rdb_1.Checked ? txtPlayer1.Text : txtPlayer2.Text;
            string secondPlayer = rdb_1.Checked ? txtPlayer2.Text : txtPlayer1.Text;

            FormGame formGame = new FormGame(firstPlayer, secondPlayer, 2, 0, SoTran());
            formGame.ShowDialog();
            this.Close();
        }
        private void errorMessage(string text)
        {
            MessageBox.Show(text, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
