using System;

namespace izpitVprEx2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Recursive: {Recursive(4)}");
            Console.WriteLine($"Iterative: {Iterative(4)}");
        }
        static decimal Recursive(decimal n)
        {
            if (n == 1)
            {
                return 4 / 3;
            }
            else if (n == 2)
            {
                return 3;
            }
            else if (n == 3)
            {
                return 4;
            }
            return Recursive(n - 1) + 2 * Recursive(n - 2) - 8 * Recursive(n - 3);
        }

        static decimal Iterative(decimal n)
        {
            if (n == 1)
            {
                return 4 / 3;
            }
            else if (n == 2)
            {
                return 3;
            }
            else if (n == 3)
            {
                return 4;
            }
            decimal n1 = 4 / 3;
            decimal n2 = 3;
            decimal n3 = 4;

            decimal result = 0;
            for (int i = 4; i <= n; i++)
            {
                result = n3 + 2 * n2 - 8 * n1;
                n1 = n2;
                n2 = n3;
                n3 = result;
            }
            return result;
        }
    }
}
