namespace Appointments1
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int n = 4;
            int[,] C = new int[,] { { 10, 20, 12, 5 }, { 3, 14, 9, 1 }, { 13, 8, 6, 9 }, { 7, 15, 6, 9 } };
            int[,] X = new int[,] { { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 } };
            int[,] C1 = new int[,] { { 10, 20, 12, 5 }, { 3, 14, 9, 1 }, { 13, 8, 6, 9 }, { 7, 15, 6, 9 } };

            int minElement = (int)Math.Pow(10, 5);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (C1[i, j] < minElement)
                    {
                        minElement = C1[i, j];
                    }
                }

                for (int j = 0; j < n; j++)
                {
                    C1[i, j] -= minElement;
                }

                minElement = (int)Math.Pow(10, 5);
            }

            minElement = (int)Math.Pow(10, 5);

            for (int j = 0; j < n; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    if (C1[i, j] < minElement)
                    {
                        minElement = C1[i, j];
                    }
                }

                for (int i = 0; i < n; i++)
                {
                    C1[i, j] -= minElement;
                }

                minElement = (int)Math.Pow(10, 5);
            }


            // Initialize jagged arrays

            int[][] markedZeros = new int[n][];
            for (int i = 0; i < n; i++)
            {
                markedZeros[i] = new int[2];
            }

            int[][] scratchedZeros = new int[n][];
            for (int i = 0; i < n; i++)
            {
                scratchedZeros[i] = new int[2];
            }

            int[][] doubleCoveredElements = new int[n][];
            for (int i = 0; i < n; i++)
            {
                doubleCoveredElements[i] = new int[2];
            }

            int[][] coveredElements = new int[n * n - n][];
            for (int i = 0; i < n * n - n; i++)
            {
                coveredElements[i] = new int[2];
            }

            int[][] uncoveredElements = new int[n * n - n][];
            for (int i = 0; i < n * n - n; i++)
            {
                uncoveredElements[i] = new int[2];
            }

            int[][] controlArray = new int[n][];
            for (int i = 0; i < n; i++)
            {
                controlArray[i] = new int[2];
            }

            int[] horizontalLines = new int[n];
            int[] verticalLines = new int[n];
            int numberMarkedZeros = 0;

            while (true)
            {
                for (int i = 0; i < n; i++)
                {
                    if (markedZeros[i][0] != n)
                    {
                        numberMarkedZeros += 1;
                    }
                }

                int jMarkedZeros = n;
                int iMarkedZeros = n;
                int k = 0;
                int m = 0;

                int counter = 0;
                int complectsZerosInRows = 0;
                int complectsZerosInColumn = 0;

                int p = 0;
                int q = 0;
                int r = 0;
                int s = 0;

                if (numberMarkedZeros < n)
                {
                    jMarkedZeros += n;
                    iMarkedZeros += n;
                    k = 0;
                    m = 0;

                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            if (C1[i, j] == 0 && counter == 0 && i != iMarkedZeros && j != jMarkedZeros)
                            {
                                markedZeros[k][0] = i;
                                markedZeros[k][1] = j;
                                k += 1;
                                counter += 1;
                                iMarkedZeros += i;
                                jMarkedZeros += j;
                            }

                            if (C1[i, j] != 0 && counter != 0 && i == iMarkedZeros && j != jMarkedZeros)
                            {
                                scratchedZeros[m][0] = i;
                                scratchedZeros[m][1] = j;
                                m += 1;
                            }

                            if (C1[i, j] == 0 && counter != 0 && i != iMarkedZeros && j == jMarkedZeros)
                            {
                                scratchedZeros[m][0] = i;
                                scratchedZeros[m][1] = j;
                                m += 1;
                            }

                            if (C1[i, j] == 0 && counter == 0 && i == iMarkedZeros && j != jMarkedZeros)
                            {
                                scratchedZeros[m][0] = i;
                                scratchedZeros[m][1] = j;
                                m += 1;
                            }

                            if (C1[i, j] == 0 && counter == 0 && i != iMarkedZeros && j == jMarkedZeros)
                            {
                                scratchedZeros[m][0] = i;
                                scratchedZeros[m][1] = j;
                                m += 1;
                            }
                        }

                        counter = 0;

                        if (i == n - 1)
                        {
                            controlArray[0] = markedZeros[k - 1];
                            markedZeros[0][k - 1] = scratchedZeros[0][m - 1];
                            scratchedZeros[m - 1] = controlArray[0];
                        }
                    }

                    for (int i = 0; i < n; i++)
                    {
                        if (markedZeros[i][0] == scratchedZeros[i][0] && markedZeros[i][0] != n && scratchedZeros[i][0] != n)
                        {
                            complectsZerosInRows += 1;
                            horizontalLines[p] += markedZeros[i][0];
                            p += 1;
                        }

                        if (markedZeros[i][1] == scratchedZeros[i][1] && markedZeros[i][1] != n && scratchedZeros[i][1] != n)
                        {
                            complectsZerosInColumn += 1;
                            verticalLines[q] += markedZeros[i][1];
                            q += 1;
                        }
                    }

                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            if (horizontalLines[j] != n && verticalLines[i] != n)
                            {
                                doubleCoveredElements[j] = new int[] { horizontalLines[j], verticalLines[i] };
                            }
                        }
                    }

                    for (int i = 0; i < n; i++)
                    {
                        if (r < horizontalLines[0])
                        {
                            coveredElements[i] = new int[] { i, verticalLines[0] };
                            r += 1;
                        }
                    }

                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            if (j < verticalLines[0] && i == horizontalLines[0])
                            {
                                coveredElements[r] = new int[] { i, j };
                                r += 1;
                            }

                            if (j < verticalLines[0] && i == horizontalLines[1])
                            {
                                coveredElements[r] = new int[] { i, j };
                                r += 1;
                            }
                        }
                    }

                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            if (!doubleCoveredElements.Any(x => x.Any(y => y == i)) &&
                                !doubleCoveredElements.Any(x => x.Any(y => y == j)) &&
                                !coveredElements.Any(x => x.Any(y => y == i)) &&
                                !coveredElements.Any(x => x.Any(y => y == j)))
                            {
                                uncoveredElements[s] = new int[] { i, j };
                                s += 1;
                            }
                        }
                    }

                    minElement = minElement = (int)Math.Pow(10, 5);

                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            if (uncoveredElements.Any(x => x.Any(y => y == i)) &&
                                uncoveredElements.Any(x => x.Any(y => y == j)))
                            {
                                if (C1[i, j] < minElement)
                                {
                                    minElement = C1[i, j];
                                }
                            }
                        }
                    }

                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            if (uncoveredElements.Any(x => x.Any(y => y == i)) &&
                                uncoveredElements.Any(x => x.Any(y => y == j)))
                            {
                                C1[i, j] += C1[i, j] - minElement;
                            }

                            if (doubleCoveredElements.Any(x => x.Any(y => y == i)) &&
                                doubleCoveredElements.Any(x => x.Any(y => y == j)))
                            {
                                C1[i, j] += C1[i, j] + minElement;
                            }
                        }
                    }
                }
                else
                {
                    break;
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == markedZeros[i][0] && j == markedZeros[i][1])
                    {
                        X[i, j] += 1;
                    }
                }
            }

            // Function result is the F we are trying to find
            int functionResult = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == markedZeros[i][0] && j == markedZeros[i][1])
                    {
                        functionResult += C[i, j];
                    }
                }
            }

            // Print matrices
            for (int row = 0; row < C1.GetLength(0); row++)
            {
                for (int col = 0; col < C1.GetLength(1); col++)
                {
                    Console.Write($"{C1[row, col]} ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();

            for (int row = 0; row < X.GetLength(0); row++)
            {
                for (int col = 0; col < X.GetLength(1); col++)
                {
                    Console.Write($"{X[row, col]} ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();

            // Final result of function
            Console.WriteLine(functionResult);
        }
    }
}
