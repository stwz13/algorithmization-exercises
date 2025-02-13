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
            int max_1 = Convert.ToInt32(Console.ReadLine());
            int max_2 = int.MinValue;
            for (int i = 0; i < n - 1; i++)
            {
                int curr = Convert.ToInt32(Console.ReadLine());
                if (curr > max_1)
                {
                    max_2 = max_1;
                    max_1 = curr;
                }
                else
                {
                    if (max_2 < curr)
                    {
                        max_2 = curr;
                    }
                }
            }
            Console.WriteLine(max_2);
        }
    }
}
