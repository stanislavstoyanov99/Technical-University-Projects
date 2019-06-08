using System;

namespace matrixArray1exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[,] matrix = new decimal[,] { { 10, 6, 7 }, { 5, 9, 1 }, { 4, 3, 2 } };
            Console.WriteLine("Max on the anti-diagonal of matrix is: {0}", MaxOnAntiDiag(matrix));
        }
        public static decimal MaxOnAntiDiag(decimal [,] matrix)
        {
            int row = 0;
            int col = matrix.GetLength(0) - 1;
            decimal max = matrix[row, col];
            while (row < matrix.GetLength(0))
            {
                if (matrix [row, col] > max)
                {
                    max = matrix[row, col];
                }
                row++;
                col--;
            }
            return max;
        }
    }
}
