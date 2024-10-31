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
            prcbCoolDown.Step=Cons.COOL_DOWN_STEP;
            prcbCoolDown.Maximum = Cons.COOL_DOWN_TIME;
            prcbCoolDown.Value = 0;


            tmCoolDown.Interval= Cons.COOL_DOWN_INTERVAL;

            ChessBoard.DrawChessBoard();
        }
        public void EndGame()
        {
            tmCoolDown.Stop();//dừng chạy thời gian
            pnlChessBoard.Enabled = false;// kết thúc game không cho đánh nữa
            MessageBox.Show("Kết thúc game !!!");
        }
        private void ChessBoard_PlayerMarked(object? sender, EventArgs e)
        {
            tmCoolDown.Start();//khi ấn vào nút bắt đầu tính giờ
            prcbCoolDown.Value=0;
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
    }
}
