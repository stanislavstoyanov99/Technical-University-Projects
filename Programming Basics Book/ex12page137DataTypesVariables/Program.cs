using System;

namespace ex12page137DataTypesVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter firstname: ");
                string firstName = Console.ReadLine();

                Console.Write("Enter surname: ");
                string surName = Console.ReadLine();

                Console.Write("Enter your age: ");
                int age = int.Parse(Console.ReadLine());

                Console.Write("Enter your gender: ");
                char gender = char.Parse(Console.ReadLine());

                Console.Write("Enter your ID: ");
                int id = int.Parse(Console.ReadLine());

                Console.WriteLine($"Your name is {firstName} {surName}, {age}-years old {gender} with {id} ID.");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
