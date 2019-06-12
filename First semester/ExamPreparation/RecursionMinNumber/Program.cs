using System;

namespace recursionMinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 15, 5, 3, 8, 9, 3, 4, 5, 7, 10, 2, 4, 7 };
            int min = array[0];
            Console.WriteLine(Recursive(array, 0, min));
        }
        public static int Recursive(int[] array, int i, int min)
        {
            if (array.Length <= i)
            {
                return min;
            }

            if (array[i] < min)
            {
                min = array[i];
            }

            return Recursive(array, i + 1, min);
        }
    }
}
