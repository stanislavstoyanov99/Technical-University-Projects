using System;
using System.Collections.Generic;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Point triangleCentre = new Point(3, 4);
            Point rectangleCentre = new Point(7, 5);

            Triangle triangle = new Triangle(triangleCentre, 6, 6, 6);
            Rectangle rectangle = new Rectangle(rectangleCentre, 5, 5);
            Shape shape = new Triangle(triangleCentre, 4, 4, 4);

            List<Shape> shapes = new List<Shape>
            {
                triangle,
                rectangle,
                shape
            };

            foreach (Shape sh in shapes)
            {
                sh.Describe();
            }
        }
    }

    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    public class Shape
    {
        protected Point Centre { get; }

        public Shape(Point centre)
        {
            Centre = centre;
        }

        public virtual void Describe()
        {
            Console.WriteLine($"This is a shape with centre coordinates {Centre.X}, {Centre.Y} ");
        }
    }

    public class Triangle : Shape
    {
        public int A { get; }
        public int B { get; }
        public int C { get; }

        public Triangle(Point centre, int a, int b, int c) : base(centre)
        {
            A = a;
            B = b;
            C = c;
        }

        public override void Describe()
        {
            Console.WriteLine($"This is a triange with centre coordinates {Centre.X}, {Centre.Y} with sides {A}, {B} and {C}");
        }
    }

    public class Rectangle : Shape
    {
        public int A { get; }
        public int B { get; }

        public Rectangle(Point centre, int a, int b) : base(centre)
        {
            A = a;
            B = b;
        }

        public override void Describe()
        {
            Console.WriteLine($"This is a rectangle with centre coordinates {Centre.X}, {Centre.Y} with sides {A} and {B}");
        }
    }
}
