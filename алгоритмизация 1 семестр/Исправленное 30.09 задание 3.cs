using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class задача_3

    {
        static void Main(string[] args)
        {
            /*3.Необходимо определить максимальную сумму подпоследовательности из четных чисел.(на отр. и полож. числах)*/
            int n = int.Parse(Console.ReadLine());

            int firstElement = int.Parse(Console.ReadLine());
            int maxSm = int.MinValue;


            int currSm = Math.Abs(firstElement) % 2 == 0 ? firstElement : 0;
            
            bool evenHere = Math.Abs(firstElement) % 2 == 0;
            for (int i = 0; i < n - 1; i++)
            {
                int secondElement = int.Parse(Console.ReadLine());
                if (Math.Abs(secondElement) % 2 == 0)
                {
                    evenHere = true;
                    currSm += secondElement;
                    if (i == n-2) maxSm = Math.Max(currSm, maxSm);
                }
                else
                {
                    
                    if (Math.Abs(firstElement) % 2 == 0) maxSm = Math.Max(maxSm, currSm);
                    currSm = 0;
                }
                firstElement = secondElement;
            }
            if (evenHere) Console.WriteLine(maxSm);
            else Console.WriteLine("Среди введённых чисел нет чётных");

        }
    }
}
