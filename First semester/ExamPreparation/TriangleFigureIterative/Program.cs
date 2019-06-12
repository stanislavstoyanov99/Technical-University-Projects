using System;

namespace triangleFigureIterative
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input number for rows: ");
            int rows = int.Parse(Console.ReadLine()); //4

            for (int i = 1; i <= rows; i++)
            {
                for (int k = i; k > 0; k--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
