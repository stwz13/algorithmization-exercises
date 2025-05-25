
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    delegate bool SortWords(string word);
    class FileName
    {
        static List<string> SortedWords(List<string> list, SortWords sortRool)
        {
            List<string> newList = new List<string>();
            for (int i = 0; i < list.Count; i++)
            {
                if (sortRool(list[i])) newList.Add(list[i]);
            }
            return newList;
        }
        static void Main()
        {
            Console.WriteLine("Введите число слов в списке");
            int n = int.Parse(Console.ReadLine());
            var wordList = new List<string>();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Введите {i} слово");
                string s = Console.ReadLine();
                wordList.Add(s);

            }


            SortWords AWords = s => s[0] == 'A';
            var AList = SortedWords(wordList, AWords);
        }
    }
}
