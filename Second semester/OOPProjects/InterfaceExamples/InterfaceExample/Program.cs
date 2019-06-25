using System;

namespace InterfaceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Implicit implementation

            var rectangle = new Rectangle(1, 2);
            IShape shapeInt = rectangle;
            rectangle.Area();
            // ((IShape)rectangle).Area();
            shapeInt.Area();
        }
    }

    public interface IShape
    {
        float Area();
        float Perimeter();
    }

    public class Rectangle : IShape, IComparable<Rectangle>
    {
        private float a;
        private float b;

        public Rectangle(float a, float b)
        {
            this.a = a;
            this.b = b;
        }

        public float Area()
        {
            return a * b;
        }

        public float Perimeter()
        {
            return 2 * (a + b);
        }

        public void Rotate()
        {
            var t = a;
            a = b;
            b = t;
        }

        public int CompareTo(Rectangle other)
        {
            float thisArea = Area();
            float otherArea = other.Area();

            if (thisArea < otherArea)
            {
                return -1;
            }
            else if (thisArea == otherArea)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

    }
}
