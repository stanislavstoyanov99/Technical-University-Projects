using System;

namespace CompareArray
{
    class Program
    {
        //Iterative way
        //static void Main(string[] args)
        //{
        //    int[] array1 = new int[] { 1, 5, 3, 8, 9, 3, 4, 5, 7, 1, 2, 4, 7 };
        //    int[] array2 = new int[] { 1, 5, 3, 2, 9, 3, 4, 1, 7, 1, 2, 10, 9 };

        //    bool equal = true;

        //    if (array1.Length == array2.Length)
        //    {
        //        for (int i = 0; i < array1.Length; i++)
        //        {
        //            if (array1[i] != array2[i])
        //            {
        //                equal = false;
        //                break;
        //            }
        //        }
        //    }
        //    else
        //    {
        //        equal = false;
        //    }
        //}

        //Recursive way
        static void Main(string[] args)
        {
            int[] array1 = new int[] { 1, 5, 3, 8, 9, 3, 4, 5, 7, 1, 2, 4, 7 };
            int[] array2 = new int[] { 1, 5, 3, 2, 9, 3, 4, 1, 7, 1, 2, 10, 9 };
        }
        public static bool Compare (int []array1, int []array2, int i)
        {
            if (array1.Length != array2.Length)
            {
                return false;
            }
            else if (array1.Length >= i)
            {
                return true;
            }

            return Compare(array1, array2, i + 1);
        }
    }
}
