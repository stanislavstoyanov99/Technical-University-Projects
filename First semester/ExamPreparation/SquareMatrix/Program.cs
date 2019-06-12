using System;
using System.IO;

namespace squareMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the size of matrix: ");
            int n = int.Parse(Console.ReadLine()); // user inputs the size of matrix
            var matrix = new int[n, n]; // declaration of matrix

            for (int row = 0; row < n; row++) // rows
            {
                for (int col = 0; col < n; col++) // cols
                {
                    matrix[row, col] = -1; // всички елементи имат за стойност -1
                }
            }
            using (var file = File.OpenText("matrix.txt"))
            {
                var line = file.ReadLine(); // reads the line of the file

                while (line != null)
                {
                    var strValues = line.Split('\t'); // разделя елементите с разстояние tab
                    int r = int.Parse(strValues[0]) - 1; // ред
                    int c = int.Parse(strValues[1]) - 1; // стълб
                    int v = int.Parse(strValues[2]); // стойността на елемента
                    matrix[r, c] = v;
                    line = file.ReadLine();
                }

                for (int r = 0; r < n; r++) // rows
                {
                    for (int c = 0; c < n; c++) // cols
                    {
                        Console.Write(matrix[r, c] + "\t"); // print matrix with tab distance
                    }
                    Console.WriteLine();
                }

                int sumEven = 0, sumOdd = 0;
                for (int r = 0; r < n; r++)
                {
                    for (int c = 0; c < n; c++)
                    {
                        if (matrix [r, c] % 2 == 0)
                        {
                            sumEven += matrix[r, c];
                        }
                        else
                        {
                            sumOdd += matrix[r, c];
                        }
                    }
                }
                Console.WriteLine("Sum of even numbers: {0}, Sum of odd numbers: {1}", sumEven, sumOdd);

                int sumEvenRows = 0, sumOddColumns = 0;
                for (int r = 1; r < n; r += 2) // rows
                {
                    for (int c = 0; c < n; c++) // cols
                    {
                        sumEvenRows += matrix[r, c];
                    }
                }

                for (int c = 0; c < n; c += 2)
                {
                    for (int r = 0; r < n; r++)
                    {
                        sumOddColumns += matrix[r, c];
                    }
                }
                Console.WriteLine("Sum of even rows: {0}, Sum of odd columns: {1}", sumEvenRows, sumOddColumns);
            }
        }
    }
}
