using System;

namespace ExplicitOrImplicit
{
    class Program
    {
        static void Main(string[] args)
        {
            var circleImplicit = new CircleImplicit() { Position = new Point() { X = 5, Y = 10 }, Radius = 2 };

            Console.WriteLine($"X = {circleImplicit.X}, Y = {circleImplicit.Y}");
            Console.WriteLine($"X = {circleImplicit.Position.X}, Y = {circleImplicit.Position.Y}");

            var circleExplicit = new CircleExplicit() { Position = new Point() { X = 5, Y = 10 }, Radius = 2 };

            Console.WriteLine($"X = {((IPositionable)circleExplicit).X}, Y = {((IPositionable)circleExplicit).Y}");
            Console.WriteLine($"X = {circleExplicit.Position.X}, Y = {circleExplicit.Position.Y}");
        }
    }

    public interface ISurface
    {
        decimal CalculateArea();
    }

    public interface IPositionable
    {
        decimal X { get; set; }
        decimal Y { get; set; }
    }

    public struct Point : IPositionable
    {
        public decimal X { get; set; }
        public decimal Y { get; set; }
        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }

    public class CircleImplicit : IPositionable, ISurface
    {
        public Point Position;
        public decimal Radius { get; set; }

        public decimal X
        {
            get { return Position.X; }
            set { Position.X = value; }
        }

        public decimal Y
        {
            get { return Position.Y; }
            set { Position.Y = value; }
        }

        public decimal CalculateArea()
        {
            return (decimal)Math.PI * Radius * Radius;
        }

        public override string ToString()
        {
            return $"Circle at {Position} with a radius of {Radius}";
        }
    }

    public class CircleExplicit : IPositionable, ISurface
    {
        public Point Position;
        public decimal Radius { get; set; }

        decimal IPositionable.X
        {
            get { return Position.X; }
            set { Position.X = value; }
        }

        decimal IPositionable.Y
        {
            get { return Position.Y; }
            set { Position.Y = value; }
        }

        public decimal CalculateArea()
        {
            return (decimal)Math.PI * Radius * Radius;
        }

        public override string ToString()
        {
            return $"Circle at {Position} with a radius of {Radius}";
        }
    }
}
