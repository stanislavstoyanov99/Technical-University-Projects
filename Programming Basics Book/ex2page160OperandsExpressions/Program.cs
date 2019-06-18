using System;

namespace ex2page160OperandsExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            if (number % 5 == 0 && number % 7 == 0)
            {
                Console.WriteLine("It is divided by 5 and 7.");
            }
            else
            {
                Console.WriteLine("It is not divided by 5 and 7.");
            }
        }
    }
}
