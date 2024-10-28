using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Задача_3
    {
        static int p(int[,]arr, int str)
        {
            int n = arr.GetUpperBound(0) + 1;
            int m = arr.Length / n;
            int p = 1;
            for (int i = 0; i < m; i++) p *= arr[str, i];
            return p;
        }
        static int sum(int[,] arr, int str)
        {
            int n = arr.GetUpperBound(0) + 1;
            int m = arr.Length / n;
            int sum = 0;
            for (int i = 0; i < m; i++) sum += arr[str, i];
            return sum;
        }
        static int count0(int[,] arr, int str)
        {
            int n = arr.GetUpperBound(0) + 1;
            int m = arr.Length / n;
            int count0 = 0;
            for (int i = 0; i < m; i++) if (arr[str, i] == 0) count0+=1 ;
            return count0;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число строк");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число столбцов");
            int m = int.Parse(Console.ReadLine());
            int[,] arr = new int[n, m];
            
            for (int i = 0; i < n; i++) for (int j = 0; j < m; j++) arr[i, j] = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < n; i++)
            {
                for (int k = i+1; k < n; k++)
                {
                    if (p(arr, i) == p(arr, k) && sum(arr, i) == sum(arr, k) && count0(arr, i) == count0(arr, k))

                        Console.WriteLine($"Строки под номерами {i + 1} и {k + 1} совпадают");
                    
                }
            }
        }
    }
}
