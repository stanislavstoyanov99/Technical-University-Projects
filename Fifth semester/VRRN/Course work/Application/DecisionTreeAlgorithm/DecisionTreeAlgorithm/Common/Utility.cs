namespace DecisionTreeAlgorithm.Common
{
    using System;

    public static class Utility
    {
        public static void PrintMatrix<T>(T[,] array)
        {
            int rowLength = array.GetLength(0);
            int colLength = array.GetLength(1);

            for (int row = 0; row < rowLength; row++)
            {
                for (int col = 0; col < colLength; col++)
                {
                    Console.Write($"{string.Format("{0:0.00}", array[row, col])} ");
                }

                Console.WriteLine();
            }
        }

        public static void PrintArray<T>(T[] array)
        {
            for (int row = 0; row < array.Length; row++)
            {
                Console.WriteLine($"{array[row]:F2} ");
            }
        }
    }
}
