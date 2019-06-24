using System;
using System.Collections.Generic;
using System.Text;

namespace Serialization
{
    [Serializable]
    public class Triangle
    {
        public List<Triangle> _triangles = new List<Triangle>();

        public int SizeA { get; set; }

        public int SizeB { get; set; }

        public int Height { get; set; }

        public Triangle(int sizeA, int sizeB, int height)
        {
            sizeA = SizeA;
            sizeB = SizeB;
            height = Height;
        }
    }
}
