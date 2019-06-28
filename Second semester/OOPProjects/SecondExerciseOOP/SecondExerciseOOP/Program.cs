using System;
using System.Collections.Generic;

namespace SecondExerciseOOP
{
    public delegate void Click(Shape shape);

    // base class for shapes
    public abstract class Shape
    {
        protected int x, y;

        public event Click OnClick;

        public abstract double CalculateSurface();

        public void FireClick()
        {
            OnClick(this);
        }
    }

    public class Triangle : Shape
    {
        int x;
        int height;

        public override double CalculateSurface()
        {
            return x * height / 2;
        }
    }

    public class Rectangle : Shape
    {
        int x;
        int y;

        public Rectangle(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override double CalculateSurface()
        {
            return x * y;
        }

        public override string ToString()
        {
            return "Rectangle, x = " + x + ", y = " + y;
        }
    }

    public class Circle : Shape
    {
        int radius;

        public Circle(int radius)
        {
            this.radius = radius;
        }

        public override double CalculateSurface()
        {
            return Math.PI * Math.Pow(radius, 2) / 2;
        }
    }

    public class Scene
    {
        private List<Shape> shapes = new List<Shape>();

        public void Click(int x, int y)
        {
            foreach (var shape in shapes)
            {
                if (shape is Shape && (shape as Shape).PointIn(x,y))
                {
                    shape.FireClick();
                }
            }
        }

        public double CalculateSurface()
        {
            double surface = 0.0;

            foreach (var shape in shapes)
            {
                surface += shape.CalculateSurface();
            }

            return surface;
        }
    }

    public class Program
    {
        public static void OnClickShape(Shape shape)
        {
            // TODO
        }

        static void Main(string[] args)
        {
            Scene scene = new Scene();

            var surface = scene.CalculateSurface();
            var rectangle = new Rectangle(5, 4);
            rectangle.OnClick += OnClickShape;
        }
    }
}
