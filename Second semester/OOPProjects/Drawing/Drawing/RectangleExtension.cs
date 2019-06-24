using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawing
{
    public delegate bool FindRectangle(Rectangle rectangle);

    public static class RectangleExtension
    {
        public static List<Rectangle> WhereContains(this List<Rectangle> rectangles, Point point)
        {
            List<Rectangle> resultList = new List<Rectangle>();

            foreach (var rectangle in rectangles)
            {
                if (rectangle.Contains(point))
                {
                    resultList.Add(rectangle);
                }
            }

            return resultList;
        }

        public static List<Rectangle> Where(this List<Rectangle> rectangles, FindRectangle findRectangleDelegate)
        {
            List<Rectangle> resultList = new List<Rectangle>();

            foreach (var rectangle in rectangles)
            {
                if (findRectangleDelegate(rectangle))
                {
                    resultList.Add(rectangle);
                }
            }

            return resultList;
        }
    }
}
