using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        /*2.Найти точки минимакса (минимум в строке и максимум в столбце или минимум в столбце и максимум в строке)*/
        static bool firstVariant(int [,]arr, int str, int stlb)
        {
            int m = arr.GetUpperBound(1)+1;
            int n = arr.Length / m;
            bool StrMax = true;
            bool StlbMin = true;
            for (int j = 0; j < m; j++) if (arr[str, j] > arr[str, stlb]) StrMax = false;
            for (int i = 0; i < n; i++) if (arr[i, stlb] < arr[str, stlb]) StlbMin = false;
            return StrMax && StlbMin;     
        }
        static bool secondVariant(int[,]arr, int str, int stlb)
        {
            int m = arr.GetUpperBound(1)+1;
            int n = arr.Length / m;
            bool StrMin = true;
            bool StlbMax = true;
            for (int j = 0; j < m; j++) if (arr[str, j] < arr[str, stlb]) StrMin = false;
            for (int i = 0; i<n; i++) if (arr[i,stlb] > arr[str,stlb]) StlbMax = false;
            return StrMin && StlbMax;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число строк");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число столбцов");
            int m = int.Parse(Console.ReadLine());
            int[,] arr = new int [n,m];
            for (int i = 0; i < n; i++) for (int j = 0; j < m; j++) arr[i,j] = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (firstVariant(arr, i, j) || secondVariant(arr, i, j)) Console.WriteLine($"Точка в {i+1} строке и {j+1} столбце удовлетворяет условию");
                }
            }
        }
    }
}
