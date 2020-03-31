namespace TransportTaskWholeExercise
{
    using System;

    public class Startup
    {
        public static void Main(string[] args)
        {
            int n = 3;
            int m = 4;
            int[] A = { 20, 15, 25 };
            int[] B = { 13, 17, 19, 11 };
            int[,] C = { { 6, 5, 2, 1 }, { 3, 5, 4, 2 }, { 5, 3, 6, 3 } };
            int[,] X = { { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 } };

            int i = 0;
            int j = 0;

            while (true)
            {
                if (A[i] == B[j] && i == n - 1 && j == m - 1)
                {
                    X[i, j] = A[i];
                    break;
                }
                else if (A[i] > B[j])
                {
                    X[i, j] = B[j];
                    A[i] = A[i] - B[j];
                    j++;
                }
                else if (A[i] < B[j])
                {
                    X[i, j] = A[i];
                    B[j] = B[j] - A[i];
                    i++;
                }
                else if (A[i] == B[j])
                {
                    X[i, j] = A[i];
                    i++;
                    j++;
                }
            }

            for (int row = 0; row < X.GetLength(0); row++)
            {
                for (int col = 0; col < X.GetLength(1); col++)
                {
                    Console.Write(X[row, col] + " ");
                }

                Console.WriteLine();
            }

            // Na4alen oporen plan
            Console.WriteLine();

            while (true)
            {
                int[] emptyCells = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                for (int k = 0; k < n * m - (n + m - 1); k++)
                {
                    emptyCells[k] = 0;
                }

                int[] fullCells = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                for (int k = 0; k < n + m - 1; k++)
                {
                    fullCells[i] = 0;
                }

                int p = 0;
                int q = 0;

                for (int k = 0; k < n; k++)
                {
                    for (int t = 0; t < m; t++)
                    {
                        if (X[i, j] == 0)
                        {
                            emptyCells[p] = X[i, j];
                            p++;
                        }
                        else if (X[i, j] != 0)
                        {
                            fullCells[q] = X[i, j];
                            q++;
                        }
                    }
                }

                int[] loop = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

                int i0 = 0;
                int j0 = 0;
                for (int k = 0; k < emptyCells.Length; k++)
                {

                }
            }
        }
    }
}
