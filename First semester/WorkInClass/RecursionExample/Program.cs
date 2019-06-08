using System;

namespace RecursionExample
{
    class Program
    {
        static int Iterative(int n)
        {
            if (n == 1)
            {
                return -1;
            }
            else if (n == 2 || n == 3)
            {
                return n;
            }

            var n_1 = 3;
            var n_2 = 2;
            var n_3 = -1;

            int ni = 0;
            for (int i = 4; i <= n; i++)
            {
                ni = n_1 + 3 * n_2 - 4 * n_3;
                n_3 = n_2;
                n_2 = n_1;
                n_1 = ni;
            }

            return ni;
        }

        static int Recursive (int n)
        {
            if (n == 1)
            {
                return -1;
            }
            else if (n == 2 || n == 3)
            {
                return n;
            }

            return Recursive(n - 1) + 3 * Recursive(n - 2) - 4 * Recursive(n - 3);
        }
        static void Main(string[] args)
        {

        }
    }
}
