using System;

namespace ex9Page137DataTypesVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstVariable = @"The ""use"" of quotation causes difficulties."; // exception for "", using quoted string
            string secondVariable = "The \"use\" of quotation causes difficulties.";

            Console.WriteLine(firstVariable);
            Console.WriteLine(secondVariable);
        }
    }
}
