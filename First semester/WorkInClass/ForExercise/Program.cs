using System;
namespace forExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 20; i++)
            {
                if (i % 2 == 0 && i != 10)
                {
                    Console.WriteLine($"{i} ");
                }
            }
        }
    }
}
