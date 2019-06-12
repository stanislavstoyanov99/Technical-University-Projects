using System;
using System.IO;

namespace izpitVprEx1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please input the size of matrix: ");
            int n = int.Parse(Console.ReadLine());

            decimal [,] matrix = new decimal[n, n];
            InitMatrix(matrix);
            PrintMatrix(matrix);
            Console.WriteLine($"The multiplication of even elements that are differenet from 0 is: {MultiplyElement(matrix)}");
            Console.WriteLine(CheckIdentity(matrix));
        }

        static void InitMatrix(decimal [,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = -1;
                }
            }
            using (var file = File.OpenText("matrix.txt"))
            {
                var line = file.ReadLine();
                while (line != null)
                {
                    string[] strValues = line.Split('\t');
                    int value = int.Parse(strValues[0]);
                    int r = int.Parse(strValues[1]) - 1;
                    int c = int.Parse(strValues[2]) - 1;
                    matrix[r, c] = value;
                    line = file.ReadLine();
                }
            }

        }

        static void PrintMatrix(decimal [,] matrix)
        {
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    Console.Write($"{matrix[r, c]}" + "\t");
                }
                Console.WriteLine();
            }
        }

        static decimal MultiplyElement (decimal [,] matrix)
        {
            decimal sum = 1;
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    if (matrix[r, c] % 2 == 0 && matrix[r, c] != 0)
                    {
                        sum += matrix[r, c] * matrix[r, c];
                    }
                }
            }
            return sum;
        }

        static bool CheckIdentity(decimal [,] matrix)
        {
            if (matrix.GetLength(0) != matrix.GetLength(1)) //проверява дали е квадратна матрицата
            {
                return false;
            }

            for (int r = 0; r < matrix.GetLength(0); r++) // rows и е квадратна матрица
            {
                for (int c = 0; c < matrix.GetLength(1); c++) // cols
                {
                    if (r == c && matrix[r, c] != 1) // елементите по главния диагонал
                    {
                        return false; // не е единична матрица
                    }
                    else if (r != c && matrix[r, c] != 0) // останалите елементи
                    {
                        return false; // не е единична матрица
                    }
                }
            }
            return true;
        }
    }
}
