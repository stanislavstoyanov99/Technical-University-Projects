namespace DecoratorExercise2
{
    using System;

    public class Circle : IShape
    {
        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius { get; set; }

        public void CalculateArea()
        {
            var area = Math.PI * Math.Pow(this.Radius, 2);
            Console.WriteLine();
            Console.Write($"{nameof(Circle)} area is {area:F2}");
        }

        public void CalculatePerimeter()
        {
            var perimeter = 2 * Math.PI * this.Radius;
            Console.WriteLine();
            Console.Write($"{nameof(Circle)} perimeter is {perimeter:F2}");
        }

        public void Draw()
        {
            Console.Write("Drawing circle");
        }
    }
}
