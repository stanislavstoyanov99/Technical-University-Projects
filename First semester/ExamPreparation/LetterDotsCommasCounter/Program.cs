using System;
using System.IO;

namespace letterDotsCommasCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please, input the file location: "); // E:\\ТУ - програмиране\\ExamPreparation\\letterDotsCommasCounter\\bin\\Debug\\file.txt

            string fileLocation = Console.ReadLine();
            StreamReader reader = new StreamReader(fileLocation); // creates StreamReader with the file location

            using (reader)
            {
                int dotsCounter = 0;
                int commasCounter = 0;
                int wordCounter = 0;

                bool isWord = false; // flag for words
                do
                {
                    char element = (char)reader.Read(); // takes each element from the file and casts to char
                    if (element == '.')
                    {
                        if (isWord)
                        {
                            wordCounter++;
                            isWord = false;
                        }
                        dotsCounter++;
                    }
                    else if (element == ',')
                    {
                        if (isWord)
                        {
                            wordCounter++;
                            isWord = false;
                        }
                        commasCounter++;
                    }
                    else if (Char.IsLetter(element)) // letters
                    {
                        isWord = true;
                    }
                }
                while (!reader.EndOfStream);

                if (isWord) // final if-statement if the final element is a word
                {
                    wordCounter++;
                }

                Console.WriteLine($"The number of dots is: {dotsCounter}");
                Console.WriteLine($"The number of commas is: {commasCounter}");
                Console.WriteLine($"The number of words is: {wordCounter}");
            }
        }
    }
}
