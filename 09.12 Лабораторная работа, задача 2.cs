
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Train
    {
        public string End { get; set; }
        public int Number { get; set; }
        public string Time { get; set; }

        public Train(string End, int Number, string Time)
        {
            this.End = End;
            this.Number = Number;
            this.Time = Time;
        }
        public bool isLate(string time)
        {
            string time1 = Time;

            if (int.Parse(time1.Substring(0, 2)) > int.Parse(time.Substring(0, 2))) return true;
            else if (int.Parse(time1.Substring(3, 2)) > int.Parse(time.Substring(3, 2)) && int.Parse(time1.Substring(0, 2)) == int.Parse(time.Substring(0, 2))) return true;
            else return false;
        }
        public void Print()
        {
            Console.WriteLine($"Пункт назначения {End}, номер поезда {Number}, время отправления {Time}");
        }

    }
    class Stantion : Train
    {
        public Stantion(string name, Train[] trains, string end, int number, string time) : base(end, number, time)
        {
            Name = name;
            Trains = trains;
        }
        public string Name { get; set; }
        public Train[] Trains { get; set; }

        internal class задача1

        {
            static void Main(string[] args)
            {

                Console.WriteLine("МЕНЮ \n" + "1.Заполнение\n" + "2.Модификация\n" + "3.Запрос\n" + "4.Выход");
                bool work = true;
                bool full = false;
                Train[] Trains = new Train[0];
                int n = 0;
                while (work)
                {

                    Console.WriteLine("Введите номер команды из меню");
                    int command = int.Parse(Console.ReadLine());
                    if (command == 1)
                    {
                        Console.WriteLine("Введите число поездов");
                        n = int.Parse(Console.ReadLine());
                        Trains = new Train[n];
                        for (int i = 0; i < n; i++)
                        {
                            Console.WriteLine("Введите название станции");
                            string name = Console.ReadLine();
                            Console.WriteLine("Введите номер поезда");
                            int numb = int.Parse(Console.ReadLine());
                            Console.WriteLine("Введите время отправления в формате '00:00'");
                            string time = Console.ReadLine();
                            Trains[i] = new Train(name, numb, time);
                            full = true;
                        }
                    }
                    if (command == 2)
                    {
                        if (full)
                        {
                            Console.WriteLine("Введите номер поезда, данные которого  нужно модифицировать");
                            int number = int.Parse(Console.ReadLine());
                            foreach (Train train in Trains)
                            {
                                if (train.Number == number)
                                {
                                    Console.WriteLine("Введите, какие данные хотите модифицировать: 1. Пункт назначения," +
                                        "2.Номер" + "3. Время отправления");
                                    Console.WriteLine("Введите новые данные");
                                    string newData = Console.ReadLine();
                                    int mod = int.Parse(Console.ReadLine());
                                    if (mod == 1) train.End = newData;
                                    if (mod == 2) train.Number = int.Parse(newData);
                                    if (mod == 3) train.Time = newData;

                                }
                            }
                        }
                        else Console.WriteLine("Данных нет");
                    }
                    if (command == 3)
                    {
                        {
                            Console.WriteLine("Введите нужное время");
                            string time = Console.ReadLine();
                            bool find = false;
                            foreach (Train train in Trains)
                            {
                                if (train.isLate(time)) train.Print(); find = true;
                            }
                            if (!find) Console.WriteLine("Подходящих поездов нет");
                        }
                        
                    }
                    if (command == 4) { Console.WriteLine("Работа завершена"); work = false; }
                }

            }
        }
    }
}
