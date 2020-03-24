namespace IO2
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            int[] A = { 100, 130, 170 }; // Масив съдържащ наличностите на складовете / производителите
            int[] B = { 150, 120, 80, 50 }; // Масив съдържащ потребностите
            int[,] costs = new int[,] { { 3, 5, 7, 11 }, { 1, 4, 6, 3 }, { 5, 8, 12, 7 } }; // Матрица на разходите
            int[,] solution = new int[,] { { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 } }; // Матрица на решението

            int io = 0;
            int jo = 0;
            int m = 3; // брой складове
            int n = 4; // брой потребители

            double minElement = costs[0, 0];
            double M = Math.Pow(10, 5);

            while (true)
            {
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (costs[i, j] < minElement && A[i] != 0 && B[j] != 0)
                        {
                            minElement = costs[i, j];
                            io = i;
                            jo = j;
                        }
                    }
                }

                if (A[io] > B[jo])
                {
                    solution[io, jo] = B[jo];
                    A[io] = A[io] - B[jo];
                    B[jo] = 0;
                }
                else if (A[io] < B[jo])
                {
                    solution[io, jo] = A[io];
                    B[jo] = B[jo] - A[io];
                    A[io] = 0;
                }
                else if (A[io] == B[jo])
                {
                    solution[io, jo] = A[io];
                    break;
                }

                minElement = M;
            }

            // Принтиране на матрицата
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
