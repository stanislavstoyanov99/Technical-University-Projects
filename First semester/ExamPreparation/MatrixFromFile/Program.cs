using System;
using System.IO;

namespace MatrixFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[,] matrix = null;
            using (var file = File.OpenText("matrix.txt"))
            {
                var rows = int.Parse(file.ReadLine());
                var cols = int.Parse(file.ReadLine());
                matrix = new decimal[rows, cols];
                var line = file.ReadLine();
                int r = 0; //ред, започва от 0
                while (line != null)
                {
                    var strValues = line.Split(' '); // takes each element from the row
                    for (int c = 0; c < strValues.Length; c++) // c < cols
                    {
                        matrix[r, c] = decimal.Parse(strValues[c]); // cast each element to decimal
                    }
                    line = file.ReadLine();
                    ++r;
                }

                PrintMatrix(matrix); // this function prints the matrix
                Console.WriteLine();
                Console.WriteLine("Identity = {0}", CheckIdentity(matrix)); // function tha checks whether the matrix has only 1 on its main diagonal
                Console.WriteLine();
                Console.WriteLine("Sum of negative elements on anti diagonal: {0}", SumNegativeOnAntiDiagonal(matrix));
                Console.WriteLine();
                SortMatrix(matrix); // this function sorts the matrix
                PrintMatrix(matrix); // this function prints the sorted matrix
                Console.WriteLine();
                NormalizeRows(matrix); // this function normalizes the sorted matrix
            }

        }
        static void PrintMatrix(decimal[,] matrix)
        {
            for (int r = 0; r < matrix.GetLength(0); r++) // rows
            {
                for (int c = 0; c < matrix.GetLength(1); c++) // colws
                {
                    Console.Write($"{matrix[r,c]}" + "\t");
                }
                Console.WriteLine();
            }
        }

        static bool CheckIdentity (decimal [,] m)
        {
            if (m.GetLength(0) != m.GetLength(1)) //проверява дали е квадратна матрицата
            {
                return false;
            }

            for (int r = 0; r < m.GetLength(0); r++) // rows и е квадратна матрица
            {
                for (int c = 0; c < m.GetLength(1); c++) // cols
                {
                    if (r == c && m[r, c] != 1) // елементите по главния диагонал
                    {
                        return false; // не е единична матрица
                    }
                    else if (r != c && m[r, c] != 0) // останалите елементи
                    {
                        return false; // не е единична матрица
                    }
                }
            }
            return true;
        }

        static void SortMatrix (decimal [,] m)
        {
            for (int c = 0; c < m.GetLength(1); c++) //cols
            {
                bool sorted;
                do
                {
                    sorted = true;
                    for (int r = 1; r < m.GetLength(0); r++) // rows
                    {
                        if ((c % 2 == 0 && m[r-1, c] > m[r, c]) || (c % 2 != 0 && m[r-1, c] < m[r,c]))
                        {
                            decimal temp = m[r - 1, c];
                            m[r - 1, c] = m[r, c];
                            m[r, c] = temp;
                            sorted = false;
                        }
                    }
                }
                while (!sorted);
            }
        }

        static decimal SumNegativeOnAntiDiagonal(decimal[,] m)
        {
            if (m.GetLength(0) != m.GetLength(1)) // check whether the matrix is squared
            {
                throw new ArgumentException("Matrix is not squared.");
            }
            decimal sum = 0;

            for (int r = 0; r < m.GetLength(0); r++)
            {
                var c = m.GetLength(0) - 1 - r;
                if (m[r, c] < 0) // negative numbers
                {
                    sum += m[r, c];
                }
            }
            return sum;
        }

        static void NormalizeRows(decimal[,] m)
        {
            for (int r = 0; r < m.GetLength(0); ++r)
            {
                decimal sum = 0;
                for (int c = 0; c < m.GetLength(1); ++c)
                {
                    sum += m[r, c] * m[r, c]; // calculates the square of elements
                }
                sum = (decimal)Math.Sqrt((double)sum);

                if (sum != 0)
                {
                    for (int c = 0; c < m.GetLength(1); ++c)
                    {
                        decimal newSum = m[r, c] /= sum;
                        Console.Write("{0:f3}" + "\t", newSum);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}