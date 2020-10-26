namespace DirectReplacement
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Startup
    {
        // This program is an algorithm for direct replacement - example 2.2 - page 17 from the guide
        public static void Main()
        {
            var bulgarianAlphabet = Enumerable.Range('А', 'Я' - 'А' + 1)
                .Select(i => ((char)i).ToString())
                .Where(i => i != "Ы" && i != "Э")
                .ToArray();
            var digits = Enumerable.Range(0, 10).Select(i => i.ToString()).ToArray();
            string[] specialSymbols = { " ", ".", "-", "#" };

            var allowedSymbols = string.Join("", bulgarianAlphabet)
                + ""
                + string.Join("", digits)
                + ""
                + string.Join("", specialSymbols);

            int[] symbolsToReplace =
                { 10, 20, 30, 40, 15,
                  25, 11, 21, 31, 41,
                  35, 45, 12, 22, 32,
                  42, 13, 23, 33, 43,
                  14, 24, 34, 16, 26,
                  36, 17, 27, 37, 18,
                  28, 38, 19, 29, 39,
                  1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.Write("Write input text for encryption: ");
            var inputText = Console.ReadLine();

            if (inputText.Length > 300)
            {
                Console.WriteLine("The input text should not be more than 300 symbols.");
                return;
            }

            var encryptedText = new List<string>();
            var decryptedText = new StringBuilder();

            try
            {
                for (int i = 0; i < inputText.Length; i++)
                {
                    var doesItExist = allowedSymbols.Any(x => x == inputText[i]);

                    if (doesItExist)
                    {
                        var currentLetter = allowedSymbols.First(x => x == inputText[i]);

                        var newPosition = allowedSymbols.IndexOf(currentLetter);

                        if (char.IsWhiteSpace(currentLetter))
                        {
                            encryptedText.Add(symbolsToReplace[newPosition].ToString() + " ");
                        }
                        else
                        {
                            encryptedText.Add(symbolsToReplace[newPosition].ToString());
                        }
                    }
                    else
                    {
                        throw new ArgumentException($"The letter {inputText[i]} in the input text does not exist in the allowed symbols.");
                    }
                }

                Console.WriteLine($"Encrypted text: {string.Join(" ", encryptedText)}");

                for (int i = 0; i < encryptedText.Count; i++)
                {
                    var currentValue = encryptedText[i];

                    var oldPosition = Array.IndexOf(symbolsToReplace, int.Parse(encryptedText[i]));
                    var initialLetter = allowedSymbols[oldPosition];
                    decryptedText.Append(initialLetter);
                }

                Console.WriteLine($"Decrypted text: {decryptedText}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
