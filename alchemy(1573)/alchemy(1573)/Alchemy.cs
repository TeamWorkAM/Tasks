using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace alchemy_1573_
{
    class Alchemy
    {
        private static int n;
        private static uint[] c;

        public static void InputData()
        {
            Console.WriteLine("Введите количество реагентов через пробел");
            string b = Console.ReadLine();
            string[] a = b.Split(new char[] { ' ' });
            Console.WriteLine("Напишите количество цветов");
            n = Convert.ToInt32(Console.ReadLine());
            c = new uint[n];
            if(n!=a.Length)
            {
                Console.WriteLine("Неодинаковое количество цветов");
                return;
            }
            for (int i = 0; i < n; i++)
            {
                c[i] = Convert.ToUInt32(a[i]);
            }
            Console.WriteLine("Введите названия " + n + " цветов через Enter");
            for (int i = 0; i < n; i++)
            {
                Console.ReadLine();
            }
        }

        public static void CountWays()
        {
            uint count=1;
            for (int i = 0; i < n; i++)
            {
                count *= c[i];
            }
            Console.WriteLine("Количество способов: " + count);
        }
    }
}
