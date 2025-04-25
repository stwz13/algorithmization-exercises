
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    delegate void Cleaning(Car my_car);
    class Car
    {
        public int year { get; set; }
        public string brand { get; set; }
        public bool isClean { get; set; }
        public Car()
        {
            Console.WriteLine("Введите год выпуска, марку машины");

            year = int.Parse(Console.ReadLine());
            brand = Console.ReadLine();
            Console.WriteLine("Если машина чистая, введите yes");
            string check = Console.ReadLine();
            isClean = (check == "yes");
        }
    }
    class Garage
    {
        public List<Car> cars { get; set; }
        
        public Garage()
        {
            cars = new List<Car>();
        }
        public void Add(Car new_car)
        {
            cars.Add(new_car);
        }
    }
    class Washing
    {
        public static void Wash(Car curr_car)
        {
            
        if (curr_car.isClean) Console.WriteLine("Ваша машина чистая.");
        else
            {
               curr_car.isClean = true;
               Console.WriteLine("Машина помыта");
            }
        }
    }
    class Task
    {
        static void Main(string[] args)
        {
            Garage my_garage = new Garage();
            Cleaning clean = Washing.Wash;
            Console.WriteLine("Введите число машин");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Car new_car = new Car();
                my_garage.Add(new_car); 
            }
            for (int i = 0; i < n; i++)
            {
                Car curr_car = my_garage.cars[i];
                if (curr_car.isClean) continue;
                else clean(curr_car);
            }
        }
    }

}