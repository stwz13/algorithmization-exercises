using System;
using System.Reflection;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*N грядок. Размер:  l - ширинa, m - высота, k - расстояние от колодца до первой грядки. Расстоянием между грядками пренебречь.Найти суммарное 
            расстояние для полива N грядок*/
            int k = Convert.ToInt32(Console.ReadLine());
            int l = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());
            int distance = (2*k + l*(n-1)) * n / 2;
            int p = 2 * (m + l);
            int ans = (n * p) + 2*distance ;
            Console.WriteLine(ans);
        }
    }
}
