using ClassLibraryFigures;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawing
{
    [Serializable]
    public class Rectangle
    {
        public Point Position { get; set; }
        
        public int Width { get; set; }
        
        public int Height { get; set; }

        public Color Color { get; set; }

        public bool Contains(Point point)
        {
            return Position.X < point.X && (Position.X + Width) > point.X &&
                Position.Y < point.Y && (Position.Y + Height) > point.Y;
        }

        public void Paint(IGraphics graphics)
        {
            graphics.DrawRectangle(Color, Position.X, Position.Y, Width, Height);
        }
    }
}
