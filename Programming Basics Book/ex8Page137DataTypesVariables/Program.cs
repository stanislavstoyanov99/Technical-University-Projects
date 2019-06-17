using System;

namespace ex8Page137DataTypesVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstGreeting = "Hello";
            string secondGreeting = "World!";
            object obj = firstGreeting + " " + secondGreeting;
            string finalMessage = (string)obj;

            Console.WriteLine(finalMessage);
        }
    }
}
