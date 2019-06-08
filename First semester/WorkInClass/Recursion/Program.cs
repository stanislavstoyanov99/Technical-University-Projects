using System;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            uint n = uint.Parse(Console.ReadLine());
            ulong fn = Factorial(n);
            Console.WriteLine($"{n}!={fn}");
        }

        static ulong Factorial(uint n)
        {
            if (n <= 1) //Краен случай
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1); //Рекурсивен случай
            }
        }
    }
}
