using System;

namespace firstExercise20_11
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[,] matrix = new decimal[,] { {10, 9, 8 }, { 7, 6, 5 }, { 4, 3, 2 } };
            Console.WriteLine(MaxOnColumn(matrix, 2)); // matrix and the number of column
        }

        static decimal MaxOnColumn (decimal [,] matrix, int column)
        {
            column -= 1;
            decimal max = matrix[0, column];
            for (int i = 1; i < matrix.GetLength(0); i++)
            {
                if (matrix [i, column] > max)
                {
                    max = matrix[i, column];
                }
            }
            return max;
        }
    }
}
