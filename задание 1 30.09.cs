using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)

        {
            /*1.Определить максимальный размер подпоследовательности (рядом стоящие элементы, удов.условиям), состоящей из одинаковых элементов.*/
            int n = int.Parse(Console.ReadLine());
            int maxLenght = 1;
            int lengthCurrSequence = 1;
            int firstElement = int.Parse(Console.ReadLine());
            for (int i = 0; i < n - 1; i++)
            {
                int secondElement = int.Parse(Console.ReadLine());
                if (firstElement == secondElement)
                {
                    lengthCurrSequence++;
                    maxLenght = Math.Max(lengthCurrSequence, maxLenght);

                }
                else
                {
                    lengthCurrSequence = 1;
                }
                firstElement = secondElement;

            }
            Console.WriteLine(maxLenght);
        }
    }
}
