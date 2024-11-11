using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UICaro
{
    public class PlayInfo //Lưu Trữ thông tin chơi
    {
        private Point point;

        public Point Point
        {
            get { return point; }
            set { point = value; } 
        }
        public int CurrentPlayer 
        {
            get { return currentPlayer; }
            set { currentPlayer = value; } 
        }

        private int currentPlayer;
        public PlayInfo(Point point, int currentPlayer)
        {
            this.Point = point;
            this.CurrentPlayer = currentPlayer;
        }
    }
}
