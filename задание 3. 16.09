using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int firstElement = Convert.ToInt32(Console.ReadLine());
            int secondElement = Convert.ToInt32(Console.ReadLine());
            
            int ans = 0;
            for (int i = 0; i < n - 2; i++)
            {
                int thirdElement = Convert.ToInt32(Console.ReadLine());
                if (firstElement>secondElement)
                {
                    if (secondElement < thirdElement)
                    {
                        ans++;
                    }
                }
                firstElement = secondElement;
                secondElement = thirdElement;
            }
            Console.WriteLine(ans);

        }
    }
}
