using System;

namespace variant2Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Recursive: {0}", Recursive(4));
            Console.WriteLine("Iterative: {0}", Iterative(4));
        }

        static decimal Recursive (decimal n)
        {
            if (n == 1)
            {
                return n = 5 / 2;
            }
            else if (n == 2 || n == 3)
            {
                return n + 1;
            }
            return Recursive(n - 1) + 2 * Recursive(n - 2) - 3 * Recursive(n - 3);
        }

        static decimal Iterative(decimal n)
        {
            if (n == 1)
            {
                return n = 5 / 2;
            }
            else if (n == 2 || n == 3)
            {
                return n + 1;
            }

            int n1 = 5 / 2;
            int n2 = 3;
            int n3 = 4;

            int result = 0;
            for (int i = 4; i <= n; i++)
            {
                result = n3 + 2 * n2 - 3 * n1;
                n1 = n2;
                n2 = n3;
                n3 = result;
            }
            return result;
        }
    }
}
