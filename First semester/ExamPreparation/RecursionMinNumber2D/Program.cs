using System;

namespace recursionMinNumber2D
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[,] { { 6, 2, 3 }, { 4, 1, 6 }};
            int min = array[0, 0];
            Console.WriteLine(Recursive(array, 0, 0, min));
        }
        public static int Recursive(int[,] array, int i, int j, int min)
        {
            if (j >= array.GetLength(1))
            {
                return Recursive(array, i + 1, 0, min);
            }
            if (i >= array.GetLength(0))
            {
                return min;
            }
            if (array[i, j] < min)
            {
                min = array[i, j];
            }
            return Recursive(array, i, j + 1, min);
        }
    }
}
