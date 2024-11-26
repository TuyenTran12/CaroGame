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
    public partial class Form2PlayerMode : Form
    {
        public Form2PlayerMode()
        {
            InitializeComponent();
        }

        private void btn_Local_Click(object sender, EventArgs e)
        {
            Form2Player form2Player = new Form2Player();
            form2Player.ShowDialog();
            this.Close();
        }

        private void btn_LANMode_Click(object sender, EventArgs e)
        {
            FormGame2 formGame = new FormGame2("Guest","Opponent", 2, 0);

            formGame.ShowDialog();
            this.Close();
        }
    }
}
