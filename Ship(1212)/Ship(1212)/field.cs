using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ship_1212_
{
    public class field
    {
        private static uint n;//высота
        private static uint m;//ширина
        private static uint countShip;
        private static ship[] ships;

        public static void CreateField()
        {
            bool IsInput = true;
            while (IsInput)
            {
                string parameters;
                Console.WriteLine("Напишите ширину, длину поля и количество корабликов через зарятую");
                parameters = Console.ReadLine();
                string[] a = parameters.Split(' ');
                n = Convert.ToUInt16(a[0]);
                m = Convert.ToUInt16(a[1]);
                countShip = Convert.ToUInt16(a[2]);
                if (((m > 1) && (m < 30000)) && ((n > 1) && (n < 30000)) && ((countShip > 0) && (countShip < 30)))
                {
                    IsInput = false;
                }
            }
            ships = new ship[countShip];
            for (int i = 0; i < countShip; i++)
            {
                int x;
                int y;
                int CountDeck;
                char charposition;
                Position position = Position.none;
                string Parameters;
                Console.WriteLine("Напишите позицию кораблика по x,y, количество корабликов и расположение кораблика («V» — если корабль стоит вертикально и «H» — если горизонтально)");
                Parameters = Console.ReadLine();
                string[] b = Parameters.Split(' ');
                x = Convert.ToInt16(b[0]);
                y = Convert.ToInt16(b[1]);
                CountDeck = Convert.ToInt16(b[2]);
                charposition = Convert.ToChar(b[3]);
                if (charposition == 'V') position = Position.V;
                if (charposition == 'H') position = Position.H;
                ships[i] = new ship(x, y, CountDeck, position);
            }
        }
        public static void countWays()
        {
            int countDeck;
            Console.WriteLine("Напишите количество палуб у кораблика, которого нужно разместить на поле");
            countDeck = Convert.ToInt32(Console.ReadLine());
            int countways = 0;
            bool[,] r = new bool[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j  = 0; j < m; j++)
                {
                    r[i, j] = true;                  
                }
            }
            for (int i = 0; i < countShip; i++)
            {
                if (ships[i].Position == Position.H)
                {
                    r[ships[i].Y, ships[i].X - 1] = false; // перед кораблём
                    for (int d = 0; d < ships[i].countDeck; d++)
                    {

                        r[ships[i].Y - 1, ships[i].X + d] = false; // над кораблём
                        r[ships[i].Y + 1, ships[i].X + d] = false; // под кораблём
                        r[ships[i].Y, ships[i].X + d] = false; // в корабле
                    }
                    r[ships[i].Y, ships[i].countDeck + 1] = false; // за кораблём
                }

                if (ships[i].Position == Position.V)
                {
                    r[ships[i].Y - 1, ships[i].X] = false; // над кораблём
                    for (int d = 0; d < ships[i].countDeck; d++)
                    {
                        r[ships[i].Y + d, ships[i].X - 1] = false; // перед кораблём
                        r[ships[i].Y + d, ships[i].X + 1] = false; // за кораблём
                        r[ships[i].Y + d, ships[i].X] = false; // в корабле
                    }
                    r[ships[i].countDeck + 1, ships[i].X] = false; // под кораблём
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if((r[i,j]!=false)||(j<m))
                    {
                        for (int k = j; k < countDeck; k++)
                        {
                            if ((r[i, k + 1] != false) && (k < m - 1))
                            {
                                countways++;
                            }
                        }
                    }
                }
            }
            for (int j = 0; j < m; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    if ((r[i, j] != false) || (i < n))
                    {
                        for (int k = i; k < countDeck; k++)
                        {
                            if ((r[i, k + 1] != false) && (k < n - 1))
                            {
                                countways++;
                            }
                        }
                    }
                }
            }
            Console.WriteLine("Количество корабликов, которые Вы можете разместить: "+countways);
        }
    }
}

