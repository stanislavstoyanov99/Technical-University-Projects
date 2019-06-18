using System;

namespace ex4page160OperandsExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            bool isThirdDigit1Or0 = ((number >> 3) & 1) == 1;
            if (isThirdDigit1Or0)
            {
                Console.WriteLine("The third bit of {0} is 1? - {1}", number, isThirdDigit1Or0);
            }
            else
            {
                Console.WriteLine("The third bit of {0} is not 1.", number);
            }
        }
    }
}
