using System;
using System.IO;

namespace dotCommaNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please, enter file location: "); //"E:\\ТУ - програмиране\\ObligatoryHomework\\dotCommaNumber\\bin\\Debug\\file.txt"

            string fileLocation = Console.ReadLine();
            StreamReader reader = new StreamReader(fileLocation);

            using (reader)
            {
                int dotsCounter = 0;
                int commasCounter = 0;
                int numbersCounter = 0;

                bool isDigit = false;
                do
                {
                    char element = (char)reader.Read();

                    if (element == '.') // check whether the element is dot
                    {
                        if (isDigit)
                        {
                            isDigit = false;
                            numbersCounter++;
                        }
                        dotsCounter++;
                    }
                    else if (element == ',') // check whether the element is comma
                    {
                        if (isDigit)
                        {
                            isDigit = false;
                            numbersCounter++;
                        }
                        commasCounter++;
                    }
                    else if (Char.IsDigit(element)) // check whether the element is digit
                    {
                        isDigit = true;
                    }
                }
                while (!reader.EndOfStream); // until the end of stream

                if (isDigit) //final if-statement if the last element of the file is a number
                {
                    numbersCounter++;
                }

                Console.WriteLine();
                Console.WriteLine("Statistics:");
                Console.WriteLine($"Total number of dots is: {dotsCounter}");
                Console.WriteLine($"Total number of commas is: {commasCounter}");
                Console.WriteLine($"Total numbers: {numbersCounter}");
            }
        }
    }
}
