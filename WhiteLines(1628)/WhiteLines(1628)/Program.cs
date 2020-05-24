using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteLines_1628_
{
    class Program
    {
        static void Main(string[] args)
        {
            uint week, day, blacklines;
            string data;
            Console.WriteLine("Введите количество недель, дней и количество чёрных дней черезе пробел");
            data = Console.ReadLine();
            string[] a = data.Split(' ');
            week = Convert.ToUInt32(a[0]);
            day = Convert.ToUInt32(a[1]);
            blacklines = Convert.ToUInt32(a[2]);
            uint[] calendar = new uint[blacklines];
            for (int i = 0; i < blacklines; i++)
            {
                calendar[i]=
                Console.ReadLine();
            }
        }
    }
}
