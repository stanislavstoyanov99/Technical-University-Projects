using System;
using System.IO;

namespace dotCommaCounterRework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please, input the file location: "); // string path

            string fileLocation = Console.ReadLine();
            StreamReader reader = new StreamReader(fileLocation); // creates StreamReader with the file location

            using (reader)
            {
                int dotsCounter = 0;
                int commasCounter = 0;
                int numbersCounter = 0;

                bool isNumber = false; // flag for numbers
                do
                {
                    char element = (char)reader.Read(); // takes each element from the file and casts to char
                    if (element == '.')
                    {
                        if (isNumber)
                        {
                            numbersCounter++;
                            isNumber = false; // resets the flag to false
                        }
                        dotsCounter++;
                    }
                    else if (element == ',')
                    {
                        if (isNumber)
                        {
                            numbersCounter++;
                            isNumber = false; // resets the flag to false
                        }
                        commasCounter++;
                    }
                    else if (Char.IsDigit(element)) // 0-9
                    {
                        isNumber = true;
                    }
                }
                while (!reader.EndOfStream); // until the end of stream

                if (isNumber) // final if-statement if the final element is a number
                {
                    numbersCounter++;
                }
                Console.WriteLine();
                Console.WriteLine("Statistics:");
                Console.WriteLine("The number of dots is: {0}", dotsCounter);
                Console.WriteLine("The number of commas is: {0}", commasCounter);
                Console.WriteLine("Total numbers: {0}", numbersCounter);
            }
        }
    }
}
