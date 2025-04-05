using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    //Задача о гонщиках
    class lab
    {
        delegate void Message();
        class Rider
        {
            public string Name { get; set; }
            public double Speed { get; set; }
            public double CurrLocation { get; set; }
            public Rider(double start)
            {
                Console.WriteLine("Введите имя и начальную скорость гонщика");
                string name = Console.ReadLine();
                double speed = Convert.ToDouble(Console.ReadLine());
                Name = name;
                Speed = speed;
                CurrLocation = start;
            }
            public void ChangeLocation(double time)
            {
                CurrLocation += time * Speed;
            }
            public bool IsFinish(double finish)
            {
                WinnerEvent winnerEvent = new WinnerEvent();
                winnerEvent.WinnerMessage += Win;
                bool result = CurrLocation >= finish;
                if (result) winnerEvent.Event();
                return result;
            }
            public void Win()
            {
                Console.WriteLine($"{Name} победил");
            }
        }
        class WinnerEvent
        {
            public event Message WinnerMessage;
            public void Event()
            {
                if (WinnerMessage != null) WinnerMessage();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты старта и финиша");
            double start = double.Parse(Console.ReadLine());
            double finish = double.Parse(Console.ReadLine());

            Rider rider1 = new Rider(start);
            Rider rider2 = new Rider(start);
            Rider rider3 = new Rider(start);

            Console.WriteLine("Введите время, через которое изменится начальная скорость участников");
            double time = int.Parse(Console.ReadLine());

            while (true)
            {
                
                Random newRandom = new Random();

                rider1.ChangeLocation(time);
                rider2.ChangeLocation(time);
                rider3.ChangeLocation(time);

                rider1.Speed = newRandom.NextDouble();
                rider2.Speed = newRandom.NextDouble();
                rider3.Speed = newRandom.NextDouble();

                if (rider1.IsFinish(finish) || rider2.IsFinish(finish) || rider3.IsFinish(finish)) break;

            }
            
        }
    }
}
