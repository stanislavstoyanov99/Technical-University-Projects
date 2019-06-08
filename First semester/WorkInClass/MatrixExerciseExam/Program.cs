using System;
using System.IO;

namespace MatrixExerciseExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var matrix = new decimal[n, n];
            Initialize(matrix, "matrix.txt");
            PrintMatrix(matrix);
            Console.WriteLine($"Sum = {SumPositiveAndEven(matrix)}");
            int row, col;
            FindLeastPositiveElement(matrix, out row, out col);
            if (row != -1)
            {
                Console.WriteLine($"Row = {row}, Col = {col}");
            }
            else
            {
                Console.WriteLine("No positive elements found.");
            }
        }
        static void Initialize (decimal [,] m, string path)
        {
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int k = 0; k < m.GetLength(1); k++)
                {
                    m[i, k] = -1;
                }
            }
            using (var f = File.OpenText(path))
            {
                while (!f.EndOfStream)
                {
                    // Read a line
                    var line = f.ReadLine();

                    // Parse to value, col, row
                    var values = line.Split(' ');
                    var value = decimal.Parse(values[0]);
                    var row = int.Parse(values[1]);
                    var col = int.Parse(values[2]);

                    // Assign to matrix
                    m[row, col] = value;
                }
            }
        }

        static void PrintMatrix(decimal[,] m)
        {
            for (int row = 0; row < m.GetLength(0); row++)
            {
                for (int col = 0; col < m.GetLength(1); col++)
                {
                    Console.Write(m[row, col] + "\t");
                }
                Console.WriteLine();
            }
        }

        static decimal SumPositiveAndEven(decimal[,] m)
        {
            decimal sum = 0;
            for (int row = 0; row < m.GetLength(0); row++)
            {
                for (int col = 0; col < m.GetLength(1); col++)
                {
                    if (m[row, col] > 0 && m[row, col] % 2 == 0)
                    {
                        sum += m[row, col];
                    }
                }
            }
            return sum;
        }

        static void FindLeastPositiveElement(decimal[,] m, out int leastPositiveRow, out int leastPositiveCol)
        {
            decimal positiveMin = -1;
            leastPositiveCol = -1;
            leastPositiveRow = -1;

            for (int row = 0; row < m.GetLength(0); row++)
            {
                for (int col = 0; col < m.GetLength(1); col++)
                {
                    if(m[row, col] > 0 && (m[row, col] < positiveMin || leastPositiveCol == -1))
                    {
                        positiveMin = m[row, col];
                        leastPositiveRow = row;
                        leastPositiveCol = col;
                    }
                }
            }
        }
    }
}
