using System;

namespace ex7Page136DataTypeVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            string greeting = "Hello";
            string secondGreeting = "World";
            object obj = greeting + " " + secondGreeting;

            Console.WriteLine(obj);
        }
    }
}
