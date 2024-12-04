using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoCaro
{
    public partial class FormGame : Form
    {
        #region Properties
        ChessBoardMaganer ChessBoard;
        private int currentGame = 1;
        private int totalGames;
        private bool isPlayerOneTurn;
        private string playerOne;
        private string playerTwo;
        private int scorePlayerOne = 0;
        private int scorePlayerTwo = 0;
        #endregion

        #region Methods
        public FormGame(string playerOne, string playerTwo, int numberOfPlayers, int level, int sotran)
        {
            InitializeComponent();

            ChessBoard = new ChessBoardMaganer(pnlChessBoard, txbPlayerName, picbMark, playerOne, playerTwo, numberOfPlayers, level);

            ChessBoard.EndedGame += ChessBoard_EndedGame;
            ChessBoard.PlayerMarked += ChessBoard_PlayerMarked;

            prcbCoolDown.Step = Const.COOL_DOWN_STEP;
            prcbCoolDown.Maximum = Const.COOL_DOWN_TIME;
            tmCoolDown.Interval = Const.COOL_DOWN_INTERVAL;

            this.playerOne = playerOne;
            this.playerTwo = playerTwo;
            totalGames = sotran;
            isPlayerOneTurn = true;

            NewGame();

            lb_name1.Text = playerOne;
            lb_name2.Text = playerTwo;
            lb_SoTran.Text = sotran.ToString();
        }

        void ChessBoard_PlayerMarked(object sender, EventArgs e)
        {
            tmCoolDown.Start();
            prcbCoolDown.Value = 0;
        }

        void EndGame()
        {
            tmCoolDown.Stop();
            pnlChessBoard.Enabled = false;
            undoToolStripMenuItem.Enabled = false;

            // Giả sử bạn đã có thông báo chiến thắng
            string winner = DetermineWinner();
            if (winner != "Không ai")
            {
                if (winner == playerOne)
                {
                    scorePlayerOne++;
                    lb_diem1.Text = scorePlayerOne.ToString();
                }
                else if (winner == playerTwo)
                {
                    scorePlayerTwo++;
                    lb_diem2.Text = scorePlayerTwo.ToString();
                }

                if (MessageBox.Show($"{winner} đã chiến thắng!", "Thông báo", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    if (currentGame < totalGames)
                    {
                        ContinueGame();
                    }
                    else
                    {
                        MessageBox.Show("Kết thúc tất cả các trận!");
                    }
                }
            }
            else
            {
                if (MessageBox.Show("Cả 2 người chơi hòa nhau!", "Thông báo", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    if (currentGame < totalGames)
                    {
                        ContinueGame();
                    }
                    else
                    {
                        MessageBox.Show("Kết thúc tất cả các trận!");
                    }
                }
            }
        }

        string DetermineWinner()
        {
            // Sử dụng thuộc tính Winner của ChessBoardMaganer để xác định người chiến thắng
            return ChessBoard.Winner == 0 ? playerOne : (ChessBoard.Winner == 1 ? playerTwo : "Không ai");
        }

        void NewGame()
        {
            undoToolStripMenuItem.Enabled = true;
            ChessBoard.drawChessBoard();
            pnlChessBoard.Enabled = true;

            // Thiết lập người chơi đi trước
            ChessBoard.CurrentPlayer = isPlayerOneTurn ? 0 : 1;
            ChessBoard.ChangePlayer();
        }

        void ContinueGame()
        {
            currentGame++;
            isPlayerOneTurn = !isPlayerOneTurn; // Luân phiên người chơi đi trước
            NewGame();
        }

        void Quit()
        {
            Application.Exit();
        }

        void Undo()
        {
            ChessBoard.Undo();
        }

        private void ChessBoard_EndedGame(object sender, EventArgs e)
        {
            EndGame();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Undo();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStart formStart = new FormStart();
            formStart.Show();
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
                e.Cancel = true;
        }

        private void btnPlayMusic_Click(object sender, EventArgs e)
        {
            FormMusic formMusic = new FormMusic();
            formMusic.Show();
        }

        private void txbPlayerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tmCoolDown_Tick(object sender, EventArgs e)
        {
            prcbCoolDown.PerformStep();

            if (prcbCoolDown.Value >= prcbCoolDown.Maximum)
            {
                EndGame();
            }
        }

        private void FormGame_Load(object sender, EventArgs e)
        {

        }

        private void prcbCoolDown_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
