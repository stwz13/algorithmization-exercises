
using System;


namespace ConsoleApp3
{
       
    class Task
    {
        delegate void PointUser();
        class Point
        {
            public int x { get; set; }
            public int y { get; set; }
            public Point()
            {
                Console.WriteLine("Введите координаты точки");
                int x0 = int.Parse(Console.ReadLine());
                int y0 = int.Parse(Console.ReadLine());
                x = x0;
                y = y0;
            }
            public void Displacement(int delta_x, int delta_y)
            {
                x += delta_x;
                y += delta_y;
            }
        }
        class Rectangle
        {
            public Point point1 { get; set; }
            public Point point2 { get; set; }
            public Rectangle(Point point1, Point point2)
            {
                this.point1 = point1;
                this.point2 = point2;
            }
            public bool ExtarnalPoint(Point A0)
            {
                bool result = (A0.x - point1.x) * (A0.x - point2.x) <= 0 && (A0.y - point1.y) * (A0.y - point2.y) <= 0;
                if (!result)
                {
                    PointEvent currEvent = new PointEvent();
                    currEvent.pointMessage += WrongPointMessage;
                    currEvent.OnPointMessage();
                    return true;
                }
                else return false;
            }
        }
        class PointEvent
        {
            public event PointUser pointMessage;
            public void OnPointMessage()
            {
                if (pointMessage != null) pointMessage();
            }
        }
        static void WrongPointMessage() => Console.WriteLine("Точка вне прямоугольника");
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты точек прямоугольника");

            Point pointRectangle1 = new Point();
            Point pointRectangle2 = new Point();
            Rectangle myRectangle = new Rectangle(pointRectangle1, pointRectangle2);

            Point myPoint = new Point();

            Random rnd = new Random();

            Console.WriteLine("Введите максимальное абсолютное значение для приращения");

            int max_delta = int.Parse(Console.ReadLine());
            while (true)
            {
                int delta_x = rnd.Next(-max_delta, max_delta);
                int delta_y = rnd.Next(-max_delta, max_delta);

                myPoint.Displacement(delta_x, delta_y);
                if (myRectangle.ExtarnalPoint(myPoint)) break;
            }
        }
    }
}
