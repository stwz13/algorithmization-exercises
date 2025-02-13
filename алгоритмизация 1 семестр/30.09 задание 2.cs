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
            /*2.Определить минимальную длину подпоследовательности, состоящей из нулей.*/
            int minLength=int.MaxValue;
            int n = int.Parse(Console.ReadLine());
            int firstElement = int.Parse(Console.ReadLine());
          

            int currLength = firstElement == 0 ? 1 : 0;
            bool zeroHere = firstElement == 0;
            for (int i = 0; i < n - 1; i++)
            {
                
                var secondElement = int.Parse(Console.ReadLine());
                if (secondElement == 0) 
                {
                    zeroHere = true;
                    currLength++;
                    if (i == n - 2) minLength = Math.Min(minLength, currLength);
                }
                else
                {
                    if (firstElement == 0) minLength = Math.Min(minLength, currLength);
                    currLength = 0;

                }
                firstElement = secondElement;
            }    
            minLength = zeroHere ? minLength : 0;
            Console.WriteLine(minLength);
        }
    }
}
