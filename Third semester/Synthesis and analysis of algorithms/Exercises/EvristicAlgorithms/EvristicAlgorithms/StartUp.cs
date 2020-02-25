namespace EvristicAlgorithms
{
    using System;
    using System.Linq;

    public class StartUp
    {
        static Random rand = new Random();

        public static void Main(string[] args)
        {
            int[] time = new int[1000];
            int[] profit = new int[1000];

            for (int i = 0; i < 1000; i++)
            {
                time[i] = rand.Next(0, 100);
                profit[i] = rand.Next(0, 100);
            }

            var totalTime = time.Sum() * 0.75;

            int[] solution = new int[1000];

            for (int i = 0; i < solution.Length; i++)
            {
                solution[i] = rand.Next(0, 2);
            }


        }

        public static int Evaluate(int[] solution, int[] time, int[] profit, int totalTime)
        {
            int result = 0;

            for (int i = 0; i < solution.Length; i++)
            {
                if (solution[i] == 1)
                {
                    result += profit[i];
                    totalTime -= time[i];
                }
            }

            if (totalTime < 0)
            {
                return -1;
            }

            return result;
        }

        public static int[] NextSolution(int[] solution, int[] time, int[] profit, int totalTime)
        {
            int[] result = new int[solution.Length];
            Array.Copy(solution, result, solution.Length);

            int[] bestResult = new int[] { };
            int bestE = -1;

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = result[i] == 1 ? 0 : 1;

                int e = Evaluate(result, time, profit, totalTime);

                if (e > bestE)
                {
                    bestE = e;
                    bestResult = result.ToArray();
                    //bestResult[i] = bestResult[i] == 1 ? 0 : 1;
                }
            }

            return bestResult;
        }

        public static void HillClimbingSteepestAscent(int[] solution, DateTime deadline)
        {
            var bestSolution = solution[0];
            int candidateSolution = bestSolution;
        }
    }
}
