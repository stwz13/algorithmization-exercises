using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Входные данные");
            int n = int.Parse(Console.ReadLine());
            int number = -1;
            double minPrice = int.MaxValue;
            for (int i = 0; i < n; i++)
            {
                var s = Console.ReadLine().Replace('.',',').Split();
                int x1 = int.Parse(s[0]);
                int y1 = int.Parse(s[1]);
                int z1 = int.Parse(s[2]);
                int x2 = int.Parse(s[3]);
                int y2 = int.Parse(s[4]);
                int z2 = int.Parse(s[5]);

                double milkPrice;
                float c1 = float.Parse(s[6]);
                float c2 = float.Parse(s[7]);

                int s1 = 2 * (x1 * y1 + x1 * z1 + y1 * z1);
                int s2 = 2 * (x2 * y2 + x2 * z2 + y2 * z2);

                int v1 = x1 * y1 * z1;
                int v2 = x2 * y2 * z2;

                milkPrice = 1000*(c2 - c1 * s2 / s1) / (v2 - v1*s2/s1);
                if (milkPrice < minPrice)
                {
                    minPrice = milkPrice;
                    number = i + 1;
                }
                else if (milkPrice == minPrice) number = Math.Min(number, i + 1);
            }
            Console.WriteLine($"Выходные данные {number} {minPrice:0.00}");
        }
    }
}
