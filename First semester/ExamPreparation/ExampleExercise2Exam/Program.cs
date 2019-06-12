using System;

namespace ExampleExercise2Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ai = 3 * Ai-3 + 4 * Ai-2 - 7 * Ai-1
            // A1 = 2, A2 = 4, A3 = 6

            Console.WriteLine(FuncAInterativeWay(6));
            Console.WriteLine(FuncA(6));
        }
        public static int FuncA (int n)
        {
            if (n == 1)
            {
                return 2;
            }
            else if (n == 2)
            {
                return 4;
            }
            else if (n == 3)
            {
                return 6;
            }
            else
            {
                return 3 * FuncA(n - 3) + 4 * FuncA(n - 2) - 7 * FuncA(n - 1);
            }
        }
        public static int FuncAInterativeWay (int n)
        {
            int a1 = 2, a2 = 4, a3 = 6;
            int result = 0;

            for (int i = 4; i <= n; i++)
            {
                result = 3 * a1 + 4 * a2 - 7 * a3;
                a1 = a2;
                a2 = a3;
                a3 = result;
            }
            return result;
        }
    }
}
