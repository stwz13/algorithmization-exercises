using System;
using System.Reflection;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int mn = (a + b - Math.Abs(a - b)) / 2;
            Console.WriteLine(mn);

        }
    }
}
