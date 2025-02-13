using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Практическая_работа_16
    {
        static int[] ReadMassive()
        {

            Console.WriteLine("Введите количество элементов в массиве");
            int n = int.Parse(Console.ReadLine());
            int[] m = new int[n];
            for (int i = 0; i < n; i++) m[i] = int.Parse(Console.ReadLine());
            return m;
        }
        static void Sum(int[] m)
        {
            int sum = 0;
            bool numbHere = false;
            for (int i = 0; i < m.Length; i++)
            {
                if (m[i]%3 == 0)
                {
                    numbHere = true;
                    sum += m[i];
                }
            }
            if (numbHere) Console.WriteLine($"Сумма элементов, кратных 3 = {sum}");
            else Console.WriteLine("В массиве нет чисел, кратных 3");
        }
        static void P(int[] m)
        {
            int p = 1;
            bool numbHere = false;
            for (int i = 0; i < m.Length; i++)
            {
                if (m[i] % 2 == 1)
                {
                    numbHere = true;
                    p *= m[i];
                }
            }
            if (numbHere) Console.WriteLine($"Произведение нечетных элементов = {p}");
            else Console.WriteLine("В массиве нет нечетных чисел");
        }
        static void countOfZeros(int[] m)
        {
            int count = 0;
            bool zeroHere = false;
            for (int i = 0; i < m.Length; i++)
            {
                if (m[i] == 0)
                {
                    zeroHere = true;
                    count++;
                }
            }
            if (zeroHere) Console.WriteLine($"Количество нулей в массиве = {count}");
            else Console.WriteLine("В массиве нет нулей");
        }

        static void Main(string[] args) 
        {
            
            for (int i = 0; i < 3; i++)
            {
                int[] m = ReadMassive();
                
                Sum(m);
                P(m);
                countOfZeros(m);  
            }
        }
    }
}
