using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
           
            Дан массив из N элементов, состоящий из переменных целого типа. 
            Необходимо определить:
            1. Все ли элементы расположены в порядке возрастания.
            2. Определить количество элементов, значения которых оканчиваются на 3.
            3. Для каждого элемента найти сумму цифр.
            4. Определить среднее арифметическое четных элементов массива.

            */
            int N = int.Parse(Console.ReadLine());
            int[] m = new int[N];
            for (int i = 0; i < N; i++) m[i] = int.Parse(Console.ReadLine());
            bool evenHere = false;
            bool isGrowing = true;
            int endWith3 = 0;
            int sumOfEven = 0;
            int countOfEven = 0;
            for (int i = 0; i < N; i++)
            {
                int copy = m[i];
                int sumNumbers = 0;

                if (i!=N-1 && m[i+1] <= m[i]) isGrowing = false;
                if (Math.Abs(m[i]) % 10 == 3) endWith3 += 1;
                
                while (copy != 0)
                {
                    sumNumbers += Math.Abs(copy) % 10;
                    copy /= 10;
                }

                if (Math.Abs(m[i])%2 == 0)
                {
                    evenHere = true;
                    countOfEven++;
                    sumOfEven += m[i];
                }
                Console.WriteLine($"Сумма цифр элемента {m[i]} равна {sumNumbers}");
            }
            var sr = 1.0 * sumOfEven / countOfEven;
            if (isGrowing) Console.WriteLine("Элементы массива строго возрастают");
            else Console.WriteLine("Элементы массива не расположены в порядке возрастания");
            Console.WriteLine($"{endWith3} элементов оканчиваются на 3");
            
            if (evenHere) Console.WriteLine($"Среднее арифметическое четных элементов  = {sr}");
            else Console.WriteLine($"В массиве нет четных элементов");
        }
    }
}
