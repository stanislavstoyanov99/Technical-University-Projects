using System;

namespace recursionMoodle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Recursion: {0}", Recursion(4));
            Console.WriteLine("Iterative way: {0}", Iterative(4));
        }
        static int Recursion(int n)
        {
            if (n == 1 || n == 2 || n == 3)
            {
                return n * 2;
            }
            return 3 * Recursion(n - 3) + 4 * Recursion(n - 2) - 7 * Recursion(n - 1);
        }

        static int Iterative(int n)
        {
            if (n == 1 || n == 2 || n == 3)
            {
                return n * 2;
            }
            int n1 = 2;
            int n2 = 4;
            int n3 = 6;

            int result = 0;
            for (int i = 4; i <= n; i++)
            {
                result = 3 * n1 + 4 * n2 - 7 * n3;
                n1 = n2;
                n2 = n3;
                n3 = result;
            }
            return result;
        }
    }
}
