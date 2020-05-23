using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ship_1212_
{
    public enum Position {V='V',H='H', none}
    public class ship
    {
        private int x;
        private int y;
        private int CountDeck;
        private Position position;

        public ship (int x, int y, int count, Position position)
        {
            this.x = x;
            this.y = y;
            CountDeck = count;
            this.position = position;
        }

        public int X
        {
            get
            {
                return x;
            }

        }
        public int Y
        {
            get
            {
                return y;
            }
        }
        public int countDeck
        {
            get
            {
                return CountDeck;
            }
        }
        public Position Position
        {
            get
            {
                return position;
            }
        }
    }
}
