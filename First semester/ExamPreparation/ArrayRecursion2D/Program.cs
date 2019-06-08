using System;

namespace arrayRecursion2D
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[,] { { 1, 5, 3 }, { 8, 9, 3 }};
            Recursive(array, 0, 0);
        }

        public static void Recursive(int[,] array, int i, int j)
        {
            if (i >= array.GetLength(1))
            {
                return;
            }

            if (j >= array.GetLength(0))
            {
                Console.WriteLine();

                Recursive(array, i + 1, 0);
                return;
            }

            Console.Write(array[i, j] + ", ");
            Recursive(array, i, j + 1);
        }
    }
}
