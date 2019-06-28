using System;
using System.Collections.Generic;
using System.Linq;

namespace Shape
{
    public abstract class Shape
    {
        public abstract double Area();
        public abstract double Perimeter();
    }

    public class Circle : Shape
    {
        public double Radius { get; }
        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }

    public class Rectangle: Shape
    {
        public double SizeA { get; }
        public double SizeB { get; }

        public Rectangle(double sizeA, double sizeB)
        {
            SizeA = sizeA;
            SizeB = sizeB;
        }

        public override double Area()
        {
            return SizeA * SizeB;
        }

        public override double Perimeter()
        {
            return 2 * (SizeA + SizeB);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(5);
            Rectangle rectangle = new Rectangle(3, 6);

            List<Shape> shapes = new List<Shape>();
            shapes.Add(circle);
            shapes.Add(rectangle);
            shapes.Add(new Circle(8));
            shapes.Add(new Rectangle(8, 7));
            shapes.Add(new Circle(15));

            foreach (Shape sh in shapes)
            {
                if (sh is Circle)
                {
                    Console.WriteLine($"This is a circle with radius {(sh as Circle).Radius:F2}");
                }

                if (sh is Rectangle)
                {
                    Console.WriteLine($"This is a rectangle with sizeA: {(sh as Rectangle).SizeA} and sizeB: {(sh as Rectangle).SizeB}");
                }

                Console.WriteLine($"Perimeter is: {sh.Perimeter():F2}");
            }

            Console.WriteLine($"Perimeter of circle with radius {circle.Radius:F2} is {circle.Perimeter():F2}");
            Console.WriteLine($"Perimeter of rectangle with sizeA: {rectangle.SizeA} and sizeB: {rectangle.SizeA} is {rectangle.Perimeter()}");

            Console.WriteLine($"Area of circle with radius {circle.Radius:F2} is {circle.Area():F2}");
            Console.WriteLine($"Area of rectangle with sizeA: {rectangle.SizeA} and sizeB: {rectangle.SizeB} is {rectangle.Area()}");
            Console.ReadKey();
        }
    }
}
