using System;
using System.IO;

namespace nestedMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var file = File.OpenText("matrix.txt"))
            {
                int bestSum = int.MinValue;
                int bestRow = 0;
                int bestCol = 0;

                while (!file.EndOfStream)
                {
                    int sizeMatrix = int.Parse(file.ReadLine());
                    int[,] matrix = new int[sizeMatrix, sizeMatrix];

                    var line = file.ReadLine();
                    var strValues = line.Split('\t');

                    for (int rows = 0; rows < strValues.Length; rows++) // creates the matrix with the numbers
                    {
                        for (int cols = 0; cols < strValues.Length; cols++)
                        {
                            matrix = new int[rows, cols];
                        }
                    }

                    for (int rows = 0; rows < matrix.GetLength(0) - 1; rows++)
                    {
                        for (int cols = 0; cols < matrix.GetLength(1) - 1; cols++)
                        {
                            int sum = matrix[rows, cols] + matrix[rows, cols + 1] + matrix[rows + 1, cols] + matrix[rows + 1, cols + 1];
                            if (sum > bestSum)
                            {
                                bestSum = sum;
                                bestCol = cols;
                                bestRow = rows;
                            }
                        }
                    }
                }
                File.WriteAllText("newfile.txt", bestSum.ToString());
                Console.WriteLine($"The highest sum of the matrix 2x2 is: {bestSum} ");
            }
        }
    }
}
