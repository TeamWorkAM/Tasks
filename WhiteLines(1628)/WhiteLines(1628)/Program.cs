using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WhiteLines_1628_
{
    class Program
    {
        static void Main(string[] args)
        {
            // недели, дни, кол-чо чёрных и белых линий
            uint week, day, blacklines, whitelines = 0;
            
            // ввод значений для календаря
            string data;
            Console.WriteLine("Введите количество недель, дней и количество чёрных дней черезе пробел");
            data = Console.ReadLine();
            string[] a = data.Split(' ');

            week = Convert.ToUInt32(a[0]);
            day = Convert.ToUInt32(a[1]);
            blacklines = Convert.ToUInt32(a[2]);

            // создание календаря
            bool[,] calendar = new bool[week + 1, day + 1];
            for (int i = 1; i < week + 1; i++)
            {
                for (int j = 1; j < day + 1; j++)
                {
                    calendar[i, j] = true;
                }
            }

            // установка черных дней
            for (int i = 0; i < blacklines; i++)
            {
                Console.WriteLine("Введите номер недели и номер дня через пробел: ");
                string blackDates = Console.ReadLine();
                string[] b = blackDates.Split(' ');
                calendar[Convert.ToInt32(b[0]), Convert.ToInt32(b[1])] = false;
            }

            // поиск белых линий
            if (day > 1)
            {
                // 1. проверка по горизонатили
                for (int i = 1; i < week + 1; i++)
                {
                    for (int j = 1; j < day + 1; j++)
                    {
                        if (calendar[i, j])
                        {
                            uint count = 0;
                            for (int k = j; k < day; k++)
                            {
                                ++count;
                                if (!calendar[i, k + 1]) break;
                            }

                            if (count % 2 == 0)
                            {
                                whitelines += count;
                                if (j == day) break; else continue;
                            }
                            else
                            {
                                whitelines += count - 1;
                                if (j == day) break; else continue;
                            }
                        }
                    }
                }
            }
            else
            {
                // 2. проверка по горизонатили
                for (int j = 1; j < day + 1; j++)
                {
                    for (int i = 1; i < week + 1; i++)
                    {
                        if (calendar[i, j])
                        {
                            uint count = 0;
                            for (int k = i; k < week; k++)
                            {
                                ++count;
                                if (!calendar[k + 1, j]) break; else ++count;
                            }

                            if (count % 2 == 0)
                            {
                                whitelines += count;
                                if (i == week) break; else continue;
                            }
                            else
                            {
                                whitelines += count - 1;
                                if (i == week) break; else continue;
                            }
                        }
                    }
                }
            }

            // вывод белых линий
            Console.WriteLine("Количество белых линий: " + whitelines);

            Console.ReadKey();
        }
    }
}
