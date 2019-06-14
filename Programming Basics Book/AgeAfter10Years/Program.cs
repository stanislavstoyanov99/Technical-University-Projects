using System;

namespace AgeAfter10Years
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter age: ");
            int age = int.Parse(Console.ReadLine());
            DateTime newAge = new DateTime(age);

            Console.WriteLine("The age after 10 years is: {0}", age + 10);
        }
    }
}
