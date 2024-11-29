using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoCaro
{
    public partial class FormStart : Form
    {
        private readonly DatabaseConnection database;
        private SqlConnection conn;
        public FormStart()
        {
            InitializeComponent();
            database = new DatabaseConnection();
        }
        public void SetUserName(string username)
        {
            txtUsername.Text = username;
            int score = database.GetScore(username);
            lb_Score.Text = "Score: " + score.ToString();
        }
        private void btnOnePlayer_Click(object sender, EventArgs e)
        {
            Form1Player form1Player = new Form1Player(txtUsername.Text);
            form1Player.ShowDialog();
        }

        private void btnTwoPlayer_Click(object sender, EventArgs e)
        {
            Form2PlayerMode form2PlayerMode = new Form2PlayerMode(txtUsername.Text);
            form2PlayerMode.ShowDialog();
        }

        private void txtLogOut_Click(object sender, EventArgs e)
        {
            database.CloseConnection(conn);
            DangNhap dn = new DangNhap();
            dn.Show();
            this.Close();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            FormChangePassword formChangePassword = new FormChangePassword(txtUsername.Text);
            formChangePassword.Show();
            this.Hide();
        }

        private void btnLeaderboard_Click(object sender, EventArgs e)
        {
            LeaderBoard lb = new LeaderBoard(txtUsername.Text);
            lb.Show();
        }

        private void lb_Score_Click(object sender, EventArgs e)
        {

        }
    }
}
