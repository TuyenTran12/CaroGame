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
        #endregion

        #region Methods
        public FormGame(string playerOne, string playerTwo, int numberOfPlayers, int level)
        {
            InitializeComponent();

            ChessBoard = new ChessBoardMaganer(pnlChessBoard, txbPlayerName, picbMark, playerOne, playerTwo, numberOfPlayers, level);

            ChessBoard.EndedGame += ChessBoard_EndedGame;
            ChessBoard.PlayerMarked += ChessBoard_PlayerMarked;

            prcbCoolDown.Step = Const.COOL_DOWN_STEP;
            prcbCoolDown.Maximum = Const.COOL_DOWN_TIME;
            tmCoolDown.Interval = Const.COOL_DOWN_INTERVAL;

            NewGame();
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
            MessageBox.Show("Kết thúc game!");
        }

        void NewGame()
        {
            undoToolStripMenuItem.Enabled = true;
            ChessBoard.drawChessBoard();
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
    }
}
