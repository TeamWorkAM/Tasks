using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteThesis_1335_
{
    class Program
    {
        static void Main(string[] args)
        {
            uint n;
            Console.WriteLine("Введите целое число от 2 до 30000: ");
            n = Convert.ToUInt32(Console.ReadLine());

            bool isFound = false;
            List<int> listA = new List<int>();
            List<int> listB = new List<int>();
            List<int> listC = new List<int>();

            for (int a = Convert.ToInt32(n * n); a < Convert.ToInt32(Math.Pow(Convert.ToDouble(n + 1), 2)); a++)
            {
                for (int b = Convert.ToInt32(n * n); b < Convert.ToInt32(Math.Pow(Convert.ToDouble(n + 1), 2)); b++)
                {
                    for (int c = Convert.ToInt32(n * n); c < Convert.ToInt32(Math.Pow(Convert.ToDouble(n + 1), 2)); c++)
                    {
                        if (((a * a) + (b * b)) % c == 0)
                        {
                            isFound = true;
                            listA.Add(a);
                            listB.Add(b);
                            listC.Add(c);
                        }
                    }
                }
            }
           
            if (!isFound)
            {
                Console.WriteLine("No solution"); 
            }
            else
            {
                Random rand = new Random();
                int i = rand.Next(0, listA.Count);

                Console.WriteLine(listA[i] + " " + listB[i] + " " + listC[i]); 
            }
              

            Console.ReadKey();
        }
    }
}
