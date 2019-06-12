using System;

namespace arrrayEvenSum
{
    class Program
    {
        //Iterative way
        //static void Main(string[] args)
        //{
        //    int[] array = new int[] { 1, 5, 3, 8, 9, 3, 4, 5, 7, 1, 2, 4, 7 };
        //    int sum = array[0];
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        if (i % 2 == 0 || array[i] == 5)
        //        {
        //            sum += array[i];
        //        }
        //        Console.WriteLine(sum);
        //    }
        //}

        //Recursive
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 5, 3, 8, 9, 3, 4, 5, 7, 1, 2, 4, 7 };
            Console.WriteLine(Recursive(array, 0));
        }
        public static int Recursive(int []array, int i)
        {
            if (array.Length <= i)
            {
                return 0;
            }
            if (i % 2 == 0 || array[i] == 5)
            {
                return Recursive(array, i + 1) + array[i];
            }
            else
            {
                return Recursive(array, i + 1);
            }
        }
    }
}
