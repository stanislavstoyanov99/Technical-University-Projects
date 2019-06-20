using System;

namespace ex13page137DataTypesVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            //First way - the best way
            int firstNumber = 5;
            int secondNumber = 10;

            int temp = firstNumber; // 5
            firstNumber = secondNumber; // 10
            secondNumber = temp; // 5

            Console.WriteLine(firstNumber);
            Console.WriteLine(secondNumber);
            
            //Second way - only for integer numbers
            int a = 2;
            int b = 3;

            a = a + b; //5
            b = a - b; // 2
            a = a - b; // 3

            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
