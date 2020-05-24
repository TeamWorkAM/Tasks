using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedianOfTheSequence_1306_
{
    class Program
    {
        static void Main(string[] args)
        {
            uint n;
            Console.WriteLine("Введите количество чисел последовательности: ");
            n = Convert.ToUInt32(Console.ReadLine());
            uint[] arr = new uint[n];
            
            Console.WriteLine("Введите числа последовательности: ");
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToUInt32(Console.ReadLine());
            }

            double res = 0;
            if (arr.Length % 2 == 0)
            {
                for (int i = 0; i < n; i++)
                {
                    res += Convert.ToDouble(arr[i]);
                }
                res /= arr.Length;
            }
            else
            {
                res = arr[Convert.ToInt32(Math.Ceiling(Convert.ToDouble(arr.Length) / 2)) - 1];
            }

            Console.WriteLine("Медиана последовательности: " + res);
            Console.ReadKey();
        }
    }
}
