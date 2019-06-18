using System;

namespace ex3page160OperandsExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int newNumber = number / 100;
            int thirdDigit = newNumber % 10;

            if (newNumber == 7)
            {
                Console.WriteLine("The third digit is 7.");
            }
            else
            {
                Console.WriteLine("The third digit is not 7.");
            }
        }
    }
}
