using System;

namespace Class
{
    class Program
    {
        public class Triangle
        {
            public int height;
            public int triangleBase;

            public Triangle(int height, int triangleBase)
            {
                this.height = height;
                this.triangleBase = triangleBase;
            }

            public int Surface()
            {
                return height * triangleBase / 2;
            }
        }

        static void Main(string[] args)
        {
            Triangle[] triangles = new Triangle[3];

            for (int i = 0; i < triangles.Length; i++)
            {
                // struct is value type, whereas class is reference type
                triangles[i] = new Triangle(0, 0); // make new instance in order not to make null reference exception

                Console.Write("Triangle " + (i + 1) + " base: ");
                triangles[i].triangleBase = int.Parse(Console.ReadLine());
                Console.Write("Triangle " + (i + 1) + " height: ");
                triangles[i].height = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("---------------------------");

            for (int i = 0; i < triangles.Length; i++)
            {
                Console.WriteLine("Triangle " + (i + 1) + " surface area: " + triangles[i].Surface());
            }
        }
    }
}
