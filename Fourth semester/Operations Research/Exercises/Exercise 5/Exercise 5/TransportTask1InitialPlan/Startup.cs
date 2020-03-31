namespace TransportTask1InitialPlan
{
    using System;

    public class Startup
    {
        public static void Main(string[] args)
        {
            int[] A = { 100, 130, 170 };
            int[] B = { 150, 120, 80, 50 };
            int[,] costs = new int[,] { { 3, 5, 7, 11 }, { 1, 4, 6, 3 }, { 5, 8, 12, 7 } };
            int[,] solution = new int[,] { { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 } };

            int i = 0;
            int j = 0;

            while (true)
            {
                if (A[i] > B[j])
                {
                    solution[i, j] = B[j];
                    A[i] = A[i] - B[j];
                    j++;
                }
                else if (A[i] < B[j])
                {
                    solution[i, j] = A[i];
                    B[j] = B[j] - A[i];
                    i++;
                }
                else if (A[i] == B[j])
                {
                    solution[i, j] = A[i];
                    break;
                }
            }

            for (int row = 0; row < solution.GetLength(0); row++)
            {
                for (int col = 0; col < solution.GetLength(1); col++)
                {
                    Console.Write(solution[row, col] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
