using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionary_1089_
{
    public class Dictionary
    {
        private static List<string> list = new List<string>();
        public static void AddWords()
        {
            string line = Console.ReadLine();
            do
            {
                list.Add(line);
                line = Console.ReadLine();
            }
            while (line != "#");
            Console.WriteLine("Вы завершили добавление слов в словарь");
        }
        public static void CheckWords()
        {
            int fail = 0;
            string sentences = Console.ReadLine();
            string[] words = sentences.Split(' ');//разделение предложения на слова;
            for (int i = 0; i < words.Length; i++)// прохождение по всем словам в предложении
            {
                for (int j = 0; j < list.Count; j++)//прохождение по всем словам в словаре
                {
                    int count = 0;
                    if (words[i].Length == list[j].Length)//сравнение длин слова из словаря и из текста
                    {
                        string r1 = words[i];
                        string r2 = list[j];
                        for (int l = 0; l < words[i].Length; l++)//счёт одинаковых букв
                        {
                            if (r1[l] == r2[l])
                            {
                                count++;
                            }
                        }
                        if (count == words[i].Length - 1)//изменение ошибки
                        {
                            words[i] = list[j];
                            fail++;
                            break;
                        }
                        else
                            continue;
                    }
                }
            }
            for (int i = 0; i < words.Length; i++)
            {
                Console.Write(words[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Количество ошибок в тексте: " + fail);
        }
    }
}
