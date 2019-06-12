using System;
using System.IO;

namespace Variant2Exercise1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Input the size of matrix: ");
            int n = int.Parse(Console.ReadLine());
            var matrix = new decimal[n, n];

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = -1;
                }
            }

            using (var file = File.OpenText("file.txt"))
            {
                var line = file.ReadLine();

                while (line != null)
                {
                    string [] strValues = line.Split('\t');
                    int v = int.Parse(strValues[0]);
                    int r = int.Parse(strValues[1]) - 1;
                    int c = int.Parse(strValues[2]) - 1;
                    matrix[r, c] = v;
                    line = file.ReadLine();
                }
                PrintMatrix(matrix);
                Console.WriteLine($"NegativeOddSum: {NegativeOddSum(matrix)}");
                MinPositiveElement(matrix);
            }
        }

        static void PrintMatrix (decimal [,] m)
        {
            for (int row = 0; row < m.GetLength(0); row++)
            {
                for (int col = 0; col < m.GetLength(1); col++)
                {
                    Console.Write($"{m[row, col]}" + "\t");
                }
                Console.WriteLine();
            }
        }

        static decimal NegativeOddSum(decimal [,] m)
        {
            decimal negativeOddSum = 0;
            for (int r = 0; r < m.GetLength(0); r++)
            {
                for (int c = 0; c < m.GetLength(1); c++)
                {
                    if (m[r, c] % 2!= 0 && m[r, c] < 0)
                    {
                        negativeOddSum += m[r, c];
                    }
                }
            }
            return negativeOddSum;
        }

        static void MinPositiveElement (decimal[,] m)
        {
            decimal row = 0;
            decimal col = 0;
             
            decimal minPositive = decimal.MaxValue;
            bool positive = true;
            for (int r = 0; r < m.GetLength(0); r++)
            {
                for (int c = 0; c < m.GetLength(1); c++)
                {
                    if (m[r, c] < minPositive && m[r, c] > 0)
                    {
                        minPositive = m[r, c];
                        row = r + 1;
                        col = c + 1;
                        positive = true;
                    }
                    else if (m[r, c] < 0)
                    {
                        positive = false;
                    }
                }
            }
            Console.WriteLine("Row: {0}, Col: {1}; {2}", row, col, positive);
        }
    }
}
