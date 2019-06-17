using System;

namespace ex2Page136DataTypesVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = 34.567839023; //15-16 digits
            float secondNumber = 12.345f; //7 digits
            float thirdNumber = 8923.1234857f; //7 digits
            decimal fourthNumber = 3456.091124875956542151256683467m; //28-29 digits

            Console.WriteLine(firstNumber);
            Console.WriteLine(secondNumber);
            Console.WriteLine(thirdNumber);
            Console.WriteLine(fourthNumber);
        }
    }
}
