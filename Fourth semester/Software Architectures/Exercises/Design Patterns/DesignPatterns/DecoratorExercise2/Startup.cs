namespace DecoratorExercise2
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var circleRadius = 5.50;
            var circle = new Circle(circleRadius);

            var sizeA = 5;
            var sizeB = 6;
            var sizeC = 7;
            var triangle = new Triangle(sizeA, sizeB, sizeC);

            circle.Draw();
            circle.CalculateArea();
            circle.CalculatePerimeter();

            triangle.Draw();
            triangle.CalculateArea();
            triangle.CalculatePerimeter();

            var circleDecorator = new ShapeDecorator(circle, triangle);
            Console.WriteLine();

            circleDecorator.Color = "Blue";
            circleDecorator.Draw();

            circleDecorator.Area = 5;
            circleDecorator.Perimeter = 6.60;
            circleDecorator.CalculateArea();
            circleDecorator.CalculatePerimeter();

            Console.WriteLine();
        }
    }
}
