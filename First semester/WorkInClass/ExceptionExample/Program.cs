using System;

namespace ExceptionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = -1;
            decimal[] matrix = null;
            do
            {
                try
                {
                    Console.WriteLine("0. Izhod");
                    Console.WriteLine("1. Vuvejdane na matrica");
                    Console.WriteLine("2. Max na glaven diagonal");
                    choice = ReadInt("Вашият избор: ");

                    switch (choice)
                    {
                        case 0: break;
                        case 1: matrix = ReadMatrix(); break;
                        case 2:
                            var max = MaxOnMainDiagonal(matrix);
                            Console.WriteLine($"Max = {max}");
                            break;
                        default:
                            Console.WriteLine("Моля изберете опция от менюто.");
                            break;
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine("Възникна грешка: " + e.Message);
                }
            }
            while (choice != 0);
        }

        static decimal [,] ReadMatrix ()
        {
            int n = ReadInt("n=");
            var matrix = new decimal[n, n];
            for (int i = 0; i < n; ++i)
            {
                string row = Console.ReadLine(); // 4 5 -1 50
                string [] strCols = row.Split(new char[] {' ', '/t'});
                strCols.Length == n
            }
        }

        static int ReadInt(string prompt)
        {
            int num;
            bool valid;
            do
            {
                Console.Write(prompt);

                valid = int.TryParse(Console.ReadLine(), out num);
                if (!valid)
                {
                    Console.WriteLine("Please, input a number.");
                }
            }
            while (!valid);

            return num;
        }
    }
}
