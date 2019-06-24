using System;

namespace Struct
{
    class Program
    {
        public struct Rectangle
        {
            public int x;
            public int y;

            public Rectangle(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            public int RectangleSurface()
            {
                return x * y;
            }

            public static int RectangleSurfaceStatic(Rectangle rectangle)
            {
                return rectangle.x * rectangle.y;
            }
        }

        static void Main(string[] args)
        {
            Rectangle firstRectangle = new Rectangle();
            firstRectangle.x = 10;
            firstRectangle.y = 15;

            Rectangle secondRectangle = new Rectangle(20, 20);

            int firstSurface = firstRectangle.RectangleSurface();
            int staticSurface = Rectangle.RectangleSurfaceStatic(firstRectangle);
            int secondSurface = secondRectangle.RectangleSurface();
        }
    }
}
