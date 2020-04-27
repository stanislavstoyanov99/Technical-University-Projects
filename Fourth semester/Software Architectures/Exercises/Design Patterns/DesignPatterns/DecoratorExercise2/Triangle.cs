namespace DecoratorExercise2
{
    using System;

    public class Triangle : IShape
    {
        public Triangle(double sizeA, double sizeB, double sizeC)
        {
            this.SizeA = sizeA;
            this.SizeB = sizeB;
            this.SizeC = sizeC;
        }

        public double SizeA { get; set; }

        public double SizeB { get; set; }

        public double SizeC { get; set; }

        // Heron's Formula
        public void CalculateArea()
        {
            var halfPerimeter = (this.SizeA + this.SizeB + this.SizeC) / 2;
            var area = Math.Sqrt(halfPerimeter * (halfPerimeter - this.SizeA) * (halfPerimeter - this.SizeB) * (halfPerimeter - this.SizeC));
            Console.WriteLine();
            Console.Write($"{nameof(Triangle)} area is {area:F2}");
        }

        public void CalculatePerimeter()
        {
            var perimeter = this.SizeA + this.SizeB + this.SizeC;
            Console.WriteLine();
            Console.Write($"{nameof(Triangle)} perimeter is {perimeter:F2}");
        }

        public void Draw()
        {
            Console.WriteLine();
            Console.Write("Drawing triangle");
        }
    }
}
