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

        //Lưu button
        private List<List<Button>> matrix;
        public List<List<Button>> Matrix
        {
            get { return matrix; }
            set { matrix = value; }
        }

        //tạo event khi người dùng click vào
        private event EventHandler playerMarked;
        public event EventHandler PlayerMarked
        {
            add
            {
                playerMarked += value;
            }
            remove
            {
                playerMarked -= value;
            }
        }
        //event endGame
        private event EventHandler endedGame;
        public event EventHandler EndedGame
        {
            add
            {
                endedGame += value;
            }
            remove
            {
                endedGame -= value;
            }
        }

        private Stack<PlayInfo> playTimeLine;

        public Stack<PlayInfo> PlayTimeLine
        {
            get { return playTimeLine; }
            set { playTimeLine = value; }
        }

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
            
            

        }
        #endregion

        #region Methods
        public void DrawChessBoard()
        {
            ChessBoard.Enabled = true; //khởi tạo lại khi kết thúc
            ChessBoard.Controls.Clear(); //Dọn những item từ game cũ khi new game

            PlayTimeLine = new Stack<PlayInfo>(); //Tạo mới dòng thời gian cho game

            currentPlayer = 0;

            ChangePlayer();

            //khởi tạo matrix
            Matrix = new List<List<Button>>();//list động nên không xđ phần tử
            Button oldButton = new Button() { Width = 0, Location = new Point(0, 0) };
            for (int i = 0; i < Cons.CHESS_BOARD_HEIGHT; i++)
            {
                Matrix.Add(new List<Button>());//Lưu mảng cho mỗi lần xử lý
                for (int j = 0; j <= Cons.CHESS_BOARD_WIDTH; j++)
                {
                    Button btn = new Button()
                    {
                        Width = Cons.CHESS_WIDTH,
                        Height = Cons.CHESS_HEIGHT,
                        Location = new Point(oldButton.Location.X + oldButton.Width, oldButton.Location.Y),
                        BackgroundImageLayout = ImageLayout.Stretch,
                        Tag = i.ToString() //xác định button nằm ở hàng nào
                    };

                    btn.Click += btn_Click;

                    ChessBoard.Controls.Add(btn);

                    Matrix[i].Add(btn);

                    oldButton = btn;
                }
                oldButton.Location = new Point(0, oldButton.Location.Y + Cons.CHESS_HEIGHT);
                oldButton.Width = 0;
                oldButton.Height = 0;
            }
        }
        void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.BackgroundImage != null)
                return;

            Mark(btn);

            PlayTimeLine.Push(new PlayInfo (GetChessPoint(btn), CurrentPlayer)); // Lấy tọa độ điểm đánh

            //Xem player hiện tại là người nào để được đánh dấu
            CurrentPlayer = CurrentPlayer == 1 ? 0 : 1;

            ChangePlayer();

            if(playerMark != null)
            {
                playerMarked(this, new EventArgs());
            }

            if (isEndGame(btn))
            {
                EndGame();
            }

}

        // Xử lý endgame
        public void EndGame()
        {
            if (endedGame != null) { 
                endedGame(this, new EventArgs()); 
            }
        }

        // Xử lý Undo
        public bool Undo()
        {
            if (PlayTimeLine.Count <= 0) //Check điều kiện lượt chơi
                return false;

            PlayInfo oldPoint = PlayTimeLine.Pop(); //Lấy điểm chơi gần nhất
            Button btn = Matrix[oldPoint.Point.Y][oldPoint.Point.X]; //Lấy tọa độ điểm chơi gần nhất

            btn.BackgroundImage = null;

            if(PlayTimeLine.Count <= 0)
            {
                CurrentPlayer = 0;
            }
            else
            {
                oldPoint = PlayTimeLine.Peek();
                CurrentPlayer = oldPoint.CurrentPlayer == 1 ? 0 : 1;
            }

            ChangePlayer();

            return true;
        }

        //Hàm xử lý endgame
        private bool isEndGame(Button btn)
        {
            return isEndHorizontal(btn) || isEndVertical(btn) || isEndPrimary(btn) || isEndSub(btn);
        }

        //Lấy tọa độ các button
        private Point GetChessPoint(Button btn)
        {
            
            int vertical = Convert.ToInt32(btn.Tag);
            int horizontal = Matrix[vertical].IndexOf(btn);

            Point point = new Point(horizontal, vertical);

            return point;
        }
        /// Xử lý hàng ngang
        private bool isEndHorizontal(Button btn)
        {
            Point point = GetChessPoint(btn);
            int countLeft = 0, countRight = 0;

            for (int i = point.X; i >= 0; i--)
            {
                if (Matrix[point.Y][i].BackgroundImage == btn.BackgroundImage)
                    countLeft++;
                else
                    break;
            }

            for (int i = point.X + 1; i < Cons.CHESS_BOARD_WIDTH; i++)
            {
                if (Matrix[point.Y][i].BackgroundImage == btn.BackgroundImage)
                    countRight++;
                else
                    break;
            }

            return countLeft + countRight >= 5; // lớn hơn = 5 thì end
        }

        ///Xử lý hàng dọc
        private bool isEndVertical(Button btn)
        {
            Point point = GetChessPoint(btn);

            int countTop = 0;
            for (int i = point.Y; i >= 0; i--)//dem doc tren
            {
                if (Matrix[i][point.X].BackgroundImage == btn.BackgroundImage)
                {
                    countTop++;
                }
                else
                    break;
            }

            int countBottom = 0;
            for (int i = point.Y + 1; i < Cons.CHESS_BOARD_HEIGHT; i++)//dem duoi
            {
                if (Matrix[i][point.X].BackgroundImage == btn.BackgroundImage)
                {
                    countBottom++;
                }
                else
                    break;
            }



            return countTop + countBottom == 5;//tong hang doc bang 5 thi endgame
        }
        ///Xử lý đường chéo chính
        private bool isEndPrimary(Button btn)
        {
            Point point = GetChessPoint(btn);

            int countTop = 0;
            for (int i = 0; i <= point.X; i++)//dem doc tren
            {
                if (point.X - i < 0 || point.Y - i < 0)//ktra nếu vượt quá mảng
                    break;

                if (Matrix[point.Y - i][point.X - i].BackgroundImage == btn.BackgroundImage)// cùng nhau giảm khi lên top
                {
                    countTop++;
                }
                else
                    break;
            }

            int countBottom = 0;
            for (int i = 1; i <= Cons.CHESS_BOARD_WIDTH - point.X; i++)//dem doc duoi
            {
                if (point.Y + i >= Cons.CHESS_BOARD_HEIGHT || point.X + i >= Cons.CHESS_BOARD_WIDTH)// lon vuot qua mang
                    break;

                if (Matrix[point.Y + i][point.X + i].BackgroundImage == btn.BackgroundImage)// cùng nhau tăng khi xuống
                {
                    countBottom++;
                }
                else
                    break;
            }



            return countTop + countBottom == 5;//tong hang doc bang 5 thi endgame
        }
        ///Xử lý đường chéo phụ
        private bool isEndSub(Button btn)        {
            Point point = GetChessPoint(btn);

            int countTop = 0;
            for (int i = 0; i <= point.X; i++)//dem doc tren
            {
                if (point.X + i > Cons.CHESS_BOARD_WIDTH || point.Y - i < 0)//ktra nếu vượt quá mảng
                    break;

                if (Matrix[point.Y - i][point.X + i].BackgroundImage == btn.BackgroundImage)// cùng nhau giảm khi lên top
                {
                    countTop++;
                }
                else
                    break;
            }

            int countBottom = 0;
            for (int i = 1; i <= Cons.CHESS_BOARD_WIDTH - point.X; i++)//dem doc duoi
            {
                if (point.Y + i >= Cons.CHESS_BOARD_HEIGHT || point.X - i < 0)// lon vuot qua mang
                    break;

                if (Matrix[point.Y + i][point.X - i].BackgroundImage == btn.BackgroundImage)// cùng nhau tăng khi xuống
                {
                    countBottom++;
                }
                else
                    break;
            }



            return countTop + countBottom == 5;//tong hang doc bang 5 thi endgame
            //return false;
        }

        private void Mark(Button btn)
        {
            //Chuyển đổi các button thành các image khi người chơi thao tác các ô chơi
            btn.BackgroundImage = Player[CurrentPlayer].Mark;

        }
        private void ChangePlayer()
        {
            PlayerName.Text = Player[CurrentPlayer].Name;
            PlayerMark.Image = Player[CurrentPlayer].Mark;
        }
        #endregion

     
    }
}
