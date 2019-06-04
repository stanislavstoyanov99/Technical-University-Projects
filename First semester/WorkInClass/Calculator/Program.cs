using System;

class Program
{
    static void Main(string[] args)
    {
        string expression = Console.ReadLine();
        double totalSum = 0;
        string fullDigit = string.Empty;

        for (int i = 0; i < expression.Length; i++)
        {
            char symbol = expression[i];
            bool isDigit = char.IsDigit(symbol);
            fullDigit += symbol;
            if (!isDigit)
            {
                totalSum += double.Parse(fullDigit);
                if (symbol == '=')
                {
                    Console.WriteLine($"{totalSum}");
                }
                else if (symbol == '+')
                {
                    totalSum += double.Parse(fullDigit);
                }
                else if (symbol == '-')
                {
                    totalSum -= double.Parse(fullDigit);
                }
            }
            else
            {

            }
        }
    }
}
