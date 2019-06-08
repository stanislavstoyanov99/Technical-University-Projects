using System;

namespace ForeachExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int sum = 0;
            foreach (var ch in input)
            {
                Console.WriteLine("The code of letter '{0}' is {1}", ch, (int)ch);
                sum += ch;
            }
            Console.WriteLine(sum);

            //var s = "152";
            //char l1 = s[0];
            //int d = l1 - '0';
            //int secondDigit = l1 - '1';
            //int thirdDigit = l1 - '2';
            //int sum = d + secondDigit + thirdDigit;
            //Console.WriteLine(sum);
        }
    }
}
