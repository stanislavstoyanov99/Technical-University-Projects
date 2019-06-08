using System;

namespace structExample
{
    class Program
    {

        struct Point
        {
            public double x, y; // член-променливи
            public void Add(Point p) // член-функция
            {
                x += p.x;
                y += p.y;
            }
            public Point(double x, double y) // конструктор
            {
                this.x = x;
                this.y = y;
            }
        }

        static void Main(string[] args)
        {
            Point p1 = new Point();
            Point p2 = new Point(5, 10);
            p1.x = 0;
            p1.y = 5;
            p1.Add(p2);
        }
    }
}
