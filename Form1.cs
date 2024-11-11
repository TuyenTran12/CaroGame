using System.Xml.Serialization;

namespace UICaro
{
    public partial class Form1 : Form
    {
        #region Properties
        ChessBoardManager ChessBoard;
        #endregion
        public Form1()
        {
            InitializeComponent();
            ChessBoard = new ChessBoardManager(pnlChessBoard, txbPlayerName, pctbMark);
            ChessBoard.EndedGame += ChessBoard_EndedGame;
            ChessBoard.PlayerMarked += ChessBoard_PlayerMarked;

            //thiết lập các chỉ số thời gian
            prcbCoolDown.Step = Cons.COOL_DOWN_STEP;
            prcbCoolDown.Maximum = Cons.COOL_DOWN_TIME;
            prcbCoolDown.Value = 0;


            tmCoolDown.Interval = Cons.COOL_DOWN_INTERVAL;

            NewGame();
        }

        #region Methods

        public void EndGame()
        {
            tmCoolDown.Stop();//dừng chạy thời gian
            pnlChessBoard.Enabled = false;// kết thúc game không cho đánh nữa
            undoToolStripMenuItem.Enabled = false; //Game end thì không đi lại được
            MessageBox.Show("Kết thúc game !!!");
        }

        public void NewGame() //Hàm tạo game mới
        {
            //Dừng bộ đếm TG trước khi tạo game mới
            prcbCoolDown.Value = 0;
            tmCoolDown.Stop();
            undoToolStripMenuItem.Enabled = true;// Mở lại chức năng undo cho game mới
            ChessBoard.DrawChessBoard();

        }

        public void Quit() //Hàm thoát
        {
            Application.Exit();
        }

        void Undo() //Hàm đánh lại
        {
            ChessBoard.Undo();
        }
        private void ChessBoard_PlayerMarked(object? sender, EventArgs e)
        {
            tmCoolDown.Start();//khi ấn vào nút bắt đầu tính giờ
            prcbCoolDown.Value = 0;
        }

        private void ChessBoard_EndedGame(object? sender, EventArgs e)
        {
            EndGame();
        }

        private void tmCoolDown_Tick(object sender, EventArgs e)
        {
            // Tăng giá trị progressBar
            prcbCoolDown.PerformStep();

            // Kiểm tra điều kiện kết thúc game
            if (prcbCoolDown.Value >= prcbCoolDown.Maximum)
            {
                EndGame();
            }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e) //Nút new game trên thanh menu
        {
            NewGame();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)//Nút undo trên thanh menu
        {
            Undo();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)//Nút thoát trên thanh menu
        {
            Quit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát", "THÔNG BÁO", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK) //Xử lý ngoại lệ nút thoát
                e.Cancel = true;
        }

        #endregion
    }
}
