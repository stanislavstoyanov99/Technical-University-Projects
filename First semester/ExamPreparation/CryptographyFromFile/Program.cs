using System;
using System.IO;

namespace cryptographyFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please, enter file location: "); //E:\\ТУ - програмиране\\ExamPreparation\\cryptographyFromFile\\bin\\Debug\\file.txt

            string fileLocation = Console.ReadLine();

            var file = File.ReadAllText(fileLocation);
            var fileAsChars = file.ToCharArray();
            string cryptoWord = "pass";

            for (int i = 0; i < fileAsChars.Length; i++)
            {
                if (!Char.IsLetter(fileAsChars[i]))
                {
                    Console.Write(" ");
                    continue;
                }

                var currentElement = fileAsChars[i] - 'a';
                var cryptoElement = cryptoWord[i % cryptoWord.Length] - 'a';

                char newElement = (char)(((cryptoElement + currentElement) % ('z' - 'a')) + 'a');
                Console.Write(newElement);
            }
            Console.WriteLine();
        }
    }
}
