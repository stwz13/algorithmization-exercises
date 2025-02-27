using System;
using System.Reflection;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*На входе подаются две перемнных а и b. Необходимо выдать мин. значение из этих двух переменных.*/
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int mn = (a + b - Math.Abs(a - b)) / 2;
            Console.WriteLine(mn);

        }
    }
}
