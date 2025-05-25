
using System;
namespace Program;

class Program
{
    delegate double Arifmetics(int x, int y);
    static void Main(string[] args)
    {
        var sum = (int x1, int x2) => x1 + x2;
        var difr = (int x1, int x2) => x1 - x2;
        var div = (int x1, int x2) =>
        {
            if (x2 == 0)
            {
                Console.WriteLine("Деление на 0");
                return -1;
            }
            else return x1 / x2;
        };
        var mult = (int x1, int x2) => x1 * x2;

        Console.WriteLine("Введите два числа");
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        Console.WriteLine($"Сумма: {sum(x, y)}\n Разность: {difr(x, y)} \n " +
            $"Деление:{div(x, y)} \n Произведение {mult(x, y)}");

    }

}
