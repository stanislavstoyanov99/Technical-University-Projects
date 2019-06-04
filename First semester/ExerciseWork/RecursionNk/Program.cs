using System;

namespace recursionNk
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Pow(2, 3));
        }
        static int Pow(int n, int k)
        {
            if (k == 1)
            {
                return n;
            }
            return Pow(n, k - 1) * n;
        }
    }
}
