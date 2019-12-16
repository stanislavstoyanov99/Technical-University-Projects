using System;
using System.IO;

namespace DynamicProgramming
{
    public class StartUp
    {
        private static int[,] matrix;

        public static void Main(string[] args)
        {
            Console.Write("Input the size of matrix: ");
            int n = int.Parse(Console.ReadLine());

            matrix = new int[n, n];

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = -1;
                }
            }

            using var file = File.OpenText("./../../../matrix.txt");

            var line = file.ReadLine();

            while (line != null)
            {
                string[] strValues = line.Split('\t', StringSplitOptions.RemoveEmptyEntries);
                int row = int.Parse(strValues[1]) - 1;
                int col = int.Parse(strValues[1]) - 1;
                int value = int.Parse(strValues[0]);

                matrix[row, col] = value;

                line = file.ReadLine();
            }
            
            ;
        }
    }
}
