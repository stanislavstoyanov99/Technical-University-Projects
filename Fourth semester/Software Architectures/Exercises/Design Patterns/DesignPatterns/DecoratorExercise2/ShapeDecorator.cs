namespace DecoratorExercise2
{
    using System;

    public class ShapeDecorator : IShape
    {
        protected IShape[] shapes;

        public ShapeDecorator(params IShape[] shapes)
        {
            this.shapes = shapes;
        }

        public string Color { get; set; }

        public double Area { get; set; }

        public double Perimeter { get; set; }

        public void CalculateArea()
        {
            foreach (var shape in this.shapes)
            {
                shape.CalculateArea();
                Console.Write($" with {this.Area} changed area");
            }
        }

        public void CalculatePerimeter()
        {
            foreach (var shape in this.shapes)
            {
                shape.CalculatePerimeter();
                Console.Write($" with {this.Perimeter} changed perimeter");
            }
        }

        public void Draw()
        {
            foreach (var shape in this.shapes)
            {
                shape.Draw();
                Console.Write($" with {this.Color} color");
            }
        }
    }
}
