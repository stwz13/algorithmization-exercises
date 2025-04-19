
using System;
using System.Collections.Generic;
using System.IO;


namespace ConsoleApp6
{
    class rgr2
    {
        class Point
        {
            public int x { get; set; }
            public int y { get; set; }
            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }
        static int Orientation(Point firstPoint, Point secondPoint, Point currPoint)
        {
            int vecrMultX = (secondPoint.x - currPoint.x) * (firstPoint.y - currPoint.y) - (secondPoint.y - currPoint.y) * (firstPoint.x - currPoint.x);
            if (vecrMultX < 0) return 1; //вправо
            else if (vecrMultX > 0) return -1; //влево
            else return 0; //коллиниарны

        }
        static void ChoosingStartPoint(List<Point> points)
        {
            points.Sort((point1, point2) => point1.x.CompareTo(point2.x));
        }
        static void Print(List<Point> points)
        {
            foreach (Point point in points)
            {
                Console.WriteLine($"{point.x}, {point.y}");
            }
        }

        static void SortPoints(List<Point> points)
        {
            for (int i = 1; i < points.Count; i++)
            {
                for (int j = 1; j < points.Count - 1; j++)
                {
                    if (Orientation(points[0], points[j], points[j+1]) == -1)
                    {
                        var copy = points[j];
                        points[j] = points[j+1];
                        points[j+1] = copy;
                    }
                }
            }
        }
        static void BuildingPolygon(List<Point> polygon, List<Point> points)
        {
            for (int i = 2; i < points.Count; i++)
            {
                while (Orientation(polygon[polygon.Count - 2], polygon[polygon.Count - 1], points[i]) == -1)
                {
                    polygon.Remove(polygon[polygon.Count - 1]);
                }
                polygon.Add(points[i]);
            }
        }
        
        static double GaussMethod(List<Point> polygon)
        {
            double s1 = 0;
            double s2 = 0;
            for (int i = 0; i < polygon.Count - 1; i++) s1 += polygon[i].x * polygon[i + 1].y;

            for (int i = 0; i < polygon.Count - 1; i++) s2 += polygon[i + 1].x * polygon[i].y;

            double s = 0.5*(s1 + polygon[polygon.Count - 1].x * polygon[0].y - s2 - polygon[0].x * polygon[polygon.Count - 1].y);
            return Math.Floor(s*100)/100;

        }

        static void Main(string[] args)
        {
            var reader = new StreamReader("input_s1_01.txt");

            int n = int.Parse(reader.ReadLine());
            List<Point> coordinates = new List<Point>();
            for (int i = 0; i < n; i++)
            {
                var s = reader.ReadLine().Split(new[] { '\t', ' ' });
                int x = int.Parse(s[0]);
                int y = int.Parse(s[1]);
                Point newCoordinates = new Point(x,y);
                if (i > 0 && x < coordinates[0].x)
                {
                    var copy = coordinates[0];
                    coordinates[0] = newCoordinates;
                    coordinates.Add(copy);
                }
                else coordinates.Add(newCoordinates);
 
            }

            ChoosingStartPoint(coordinates);
            SortPoints(coordinates);

            List<Point> polygon = new List<Point>();
            polygon.Add(coordinates[0]);
            polygon.Add(coordinates[1]);
            
            BuildingPolygon(polygon, coordinates);
            double ans = GaussMethod(polygon);
            Console.WriteLine($"{{0:F3}}", ans);
        }
    }
}
