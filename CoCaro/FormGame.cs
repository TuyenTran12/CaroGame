using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Reflection.Emit;
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
        private int totalGames = 3;
        private int scorePlayerOne = 0;
        private int scorePlayerTwo = 0;
        private bool isPlayerFirst;
        private string player1, player2, swap;
        private int NumberOfPlayers, Level;
        #endregion

        #region Methods
        public FormGame(string playerOne, string playerTwo, int numberOfPlayers, int level, int totalGames)
        {
            InitializeComponent();

            this.totalGames = totalGames;
            this.currentGame = 1;
            this.isPlayerFirst = true;
            this.player1 = playerOne;
            this.player2 = playerTwo;
            this.NumberOfPlayers = numberOfPlayers;
            this.Level = level;

            ChessBoard = new ChessBoardMaganer(pnlChessBoard, txbPlayerName, picbMark, playerOne, playerTwo, numberOfPlayers, level);

            ChessBoard.EndedGame += ChessBoard_EndedGame;
            ChessBoard.PlayerMarked += ChessBoard_PlayerMarked;

            prcbCoolDown.Step = Const.COOL_DOWN_STEP;
            prcbCoolDown.Maximum = Const.COOL_DOWN_TIME;
            tmCoolDown.Interval = Const.COOL_DOWN_INTERVAL;

            lb_name1.Text = playerOne;
            lb_name2.Text = playerTwo;
            lb_SoTran.Text = totalGames.ToString();

            // Bắt đầu trận đấu
            NewGame();
        }
        private void NewGame()
        {
            undoToolStripMenuItem.Enabled = true;
            ChessBoard.drawChessBoard();
            pnlChessBoard.Enabled = true;

            if (isPlayerFirst)
            {
                MessageBox.Show($"Bắt đầu trận {currentGame} - {player1} đi trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Bắt đầu trận {currentGame} - {player2} đi trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ChessBoard.computerMove();
            }
        }
        void ChessBoard_PlayerMarked(object sender, EventArgs e)
        {
            tmCoolDown.Start();
            prcbCoolDown.Value = 0;
        }
        private void EndGame()
        {
            tmCoolDown.Stop();
            pnlChessBoard.Enabled = false;
            undoToolStripMenuItem.Enabled = false;

            string winner = DetermineWinner();

            // Cập nhật điểm số cho người chơi
            if (winner == lb_name1.Text)
            {
                scorePlayerOne++;
                lb_diem1.Text = scorePlayerOne.ToString();
            }
            else if (winner == lb_name2.Text)
            {
                scorePlayerTwo++;
                lb_diem2.Text = scorePlayerTwo.ToString();
            }

            MessageBox.Show($"Trận {currentGame} kết thúc! {winner} đã chiến thắng!", "Kết quả trận đấu", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (currentGame < totalGames)
            {
                currentGame++;
                swap = player1;
                player1 = player2;
                player2 = swap;
                txbPlayerName.Text = ChessBoard.Players[ChessBoard.CurrentPlayer].Name;

                // Tạo lại ChessBoard với thứ tự người chơi mới
                ChessBoard = new ChessBoardMaganer(pnlChessBoard, txbPlayerName, picbMark, player1, player2, NumberOfPlayers, Level);
                ChessBoard.EndedGame += ChessBoard_EndedGame;
                ChessBoard.PlayerMarked += ChessBoard_PlayerMarked;

                prcbCoolDown.Step = Const.COOL_DOWN_STEP;
                prcbCoolDown.Maximum = Const.COOL_DOWN_TIME;
                tmCoolDown.Interval = Const.COOL_DOWN_INTERVAL;

                NewGame();
            }
            else
            {
                MessageBox.Show($"Trò chơi kết thúc!\n" +
                                 $"{lb_name1.Text}: {scorePlayerOne} điểm\n" + // Hiển thị tên từ label
                                 $"{lb_name2.Text}: {scorePlayerTwo} điểm", // Hiển thị tên từ label
                                 "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private string DetermineWinner()
        {
            if (ChessBoard.Winner == 0)
            {
                return ChessBoard.Players[0].Name;
            }
            else if (ChessBoard.Winner == 1)
            {
                return ChessBoard.Players[1].Name;
            }
            else
            {
                return "Không ai";
            }
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
        #endregion

        private void btnPlayMusic_Click(object sender, EventArgs e)
        {
            FormMusic formMusic = new FormMusic();
            formMusic.Show();
        }

        private void tmCoolDown_Tick(object sender, EventArgs e)
        {
            prcbCoolDown.PerformStep();


            if (prcbCoolDown.Value >= prcbCoolDown.Maximum)
            {

                EndGame();

            }
        }
    }
}
