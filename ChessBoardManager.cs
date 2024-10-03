using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;


namespace UICaro
{

    public class ChessBoardManager
    {
        #region Properties
        private Panel chessBoard;

        public Panel ChessBoard
        {
            get { return chessBoard; }
            set { chessBoard = value; }
        }

        private List<Player> player;

        public List<Player> Player
        {
            get => player;
            set => player = value;
        }

        private int currentPlayer;

        public int CurrentPlayer
        {
            get => currentPlayer;
            set => currentPlayer = value;
        }
        
        private TextBox playerName;

        public TextBox PlayerName { get => playerName; set => playerName = value; }        

        private PictureBox playerMark;

        public PictureBox PlayerMark { get => playerMark; set => playerMark = value; }
        #endregion

        #region Initialize
        public ChessBoardManager(Panel chessBoard, TextBox playerName, PictureBox mark)
        {
            this.ChessBoard = chessBoard;
            this.PlayerName = playerName;
            this.PlayerMark = mark;
            this.Player = new List<Player>()
            {
                new Player("Player_1", Image.FromFile(Application.StartupPath + "\\Resources\\O.png")),
                new Player("Player_2", Image.FromFile(Application.StartupPath + "\\Resources\\X.png"))
            };
            currentPlayer = 0;

            ChangePlayer();
        }

        #endregion

        #region Methods
        public void DrawChessBoard()
        {
            Button oldButton = new Button() { Width = 0, Location = new Point(0, 0) };
            for (int i = 0; i < Cons.CHESS_BOARD_HEIGHT; i++)
            {

                for (int j = 0; j <= Cons.CHESS_BOARD_WIDTH; j++)
                {
                    Button btn = new Button()
                    {
                        Width = Cons.CHESS_WIDTH,
                        Height = Cons.CHESS_HEIGHT,
                        Location = new Point(oldButton.Location.X + oldButton.Width, oldButton.Location.Y),
                        BackgroundImageLayout = ImageLayout.Stretch,
                    };

                    btn.Click += btn_Click;

                    ChessBoard.Controls.Add(btn);

                    oldButton = btn;
                }
                oldButton.Location = new Point(0, oldButton.Location.Y + Cons.CHESS_HEIGHT);
                oldButton.Width = 0;
                oldButton.Height = 0;
            }
        }
        void btn_Click(object sender, EventArgs e)
        {
            // Đổi các ô chơi thành các button để thao tác
            Button btn = sender as Button;

            //Check xem ô đó đã được đánh dấu chưa. Nếu rồi thì k đc đánh dấu ô đó nữa
            if (btn.BackgroundImage != null)
                return;

            Mark(btn);

            ChangePlayer();
        }
        private void Mark(Button btn)
        {
            //Chuyển đổi các button thành các image khi người chơi thao tác các ô chơi
            btn.BackgroundImage = Player[CurrentPlayer].Mark;

            //Xem player hiện tại là người nào để được đánh dấu
            CurrentPlayer = CurrentPlayer == 1 ? 0 : 1;
        }
        private void ChangePlayer()
        {
            PlayerName.Text = Player[CurrentPlayer].Name;
            PlayerMark.Image = Player[CurrentPlayer].Mark;
        }
        #endregion


    }
}
