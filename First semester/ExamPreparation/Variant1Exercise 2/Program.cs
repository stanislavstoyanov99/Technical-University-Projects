using System;

namespace variant1Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Recursive: {0}", Recursive(4));
            Console.WriteLine("Iterative: {0}", Iterative(4));
        }
        static int Recursive (int n)
        {
            if (n == 1)
            {
                return -1;
            }
            else if (n == 2)
            {
                return 2;
            }
            else if (n == 3)
            {
                return 3;
            }
            return Recursive(n - 1) + 5 * Recursive(n - 2) - 7 * Recursive(n - 3);
        }

        static int Iterative (int n)
        {
            if (n == 1)
            {
                return -1;
            }
            else if (n == 2)
            {
                return 2;
            }
            else if (n == 3)
            {
                return 3;
            }
            int n1 = -1;
            int n2 = 2;
            int n3 = 3;

            int result = 0;
            for (int i = 4; i <= n; i++)
            {
                result = n3 + 5 * n2 - 7 * n1;
                n1 = n2;
                n2 = n3;
                n3 = result;
            }
            return result;
        }
    }
}
