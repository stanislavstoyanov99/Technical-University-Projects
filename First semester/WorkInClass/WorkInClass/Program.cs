using System;

namespace WorkInClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //string firstInput = Console.ReadLine();
            //string secondInput = Console.ReadLine();
            //bool isEqual = firstInput == secondInput;

            //if (isEqual)
            //{
            //    Console.WriteLine("True");
            //}
            //else
            //{
            //    Console.WriteLine("False");
            //}

            //int sum = 0;
            //for (int count = 0; count < 3; count++)
            //{
            //    int number = int.Parse(Console.ReadLine());
            //    sum += number;
            //}
            //Console.WriteLine(sum);

            //int sum = 0;
            //Console.Write("Input a maximum range to calculate: ");
            //int maximumRange = int.Parse(Console.ReadLine());
            //for (int i = 0; i < maximumRange; i++)
            //{
            //    int number = int.Parse(Console.ReadLine());
            //    sum += number;
            //}
            //Console.WriteLine($"Total sum of numbers: {sum}");

            //int sum = 0;
            //string input = string.Empty;

            //for (bool b = true; b;) //Infinity cycle
            //{
            //    input = Console.ReadLine();
            //    if (input == "=")
            //    {
            //        b = false;
            //    }
            //    else
            //    {
            //        sum += int.Parse(input);
            //    }
            //}
            //Console.WriteLine($"{sum}");

            int sum = int.Parse(Console.ReadLine());

            string input = string.Empty;

            for (bool b = true; b;)
            {
                input = Console.ReadLine();
                if (input == "+")
                {
                    sum += int.Parse(Console.ReadLine());
                }
                else if (input == "-")
                {
                    sum -= int.Parse(Console.ReadLine());
                }
                else if (input == "=")
                {
                    b = false;
                }
            }
            Console.WriteLine($"{sum}");
        }
    }
}
