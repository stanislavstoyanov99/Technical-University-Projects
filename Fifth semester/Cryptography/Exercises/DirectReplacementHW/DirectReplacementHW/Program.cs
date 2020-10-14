namespace DirectReplacementHW
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    // This program is an algorithm for direct replacement - homework page 17
    public class Program
    {
        public static void Main()
        {
            var allowedSymbols = new Dictionary<string, int>()
            {
                {"А", 1 }, {"Б", 2 }, {"В", 3 }, {"Г", 4 },
                {"Д", 5 }, {"Е", 6 }, {"И", 7 }, {"К", 8 },
                {"Л", 9 }, {"М", 10 }, {"Н", 11 }, {"О", 12 },
                {"П", 13 }, {"Р", 14 }, {"С", 15 }, {"Т", 16 },
                {"У", 17 }, {"Ф", 18 }, {"Х", 19 }, {"Я", 20 },
                {"0", 21 }, {"1", 22 }, {"2", 23 }, {"3", 24 },
                {"4", 25 }, {"5", 26 }, {"6", 27 }, {"7", 28 },
                {"8", 29 }, {"9", 30 }, {"N", 31 }, {"Y", 32 },
                {"U", 33 }, {"S", 40 }, {"D", 34 }, {" ", 35 },
                {"\"", 39 }, {"'", 36 }, {"-", 37 }, {"Ъ", 38 },
            };

            Console.Write("Write input text for encryption: ");
            var inputText = Console.ReadLine();

            if (inputText.Length > 300)
            {
                Console.WriteLine("The input text should not be more than 300 symbols.");
                return;
            }

            var encryptedText = new List<string>();
            var decryptedText = new StringBuilder();

            // Logic with interval in allowedSymbols
            try
            {
                for (int i = 0; i < inputText.Length; i++)
                {
                    if (allowedSymbols.ContainsKey(inputText[i].ToString()))
                    {
                        var encryptedCode = allowedSymbols.First(x => x.Key == inputText[i].ToString()).Value;
                        encryptedText.Add(encryptedCode + " ");
                    }
                    else
                    {
                        throw new ArgumentException("The letter in the input text does not exist in the allowed symbols.");
                    }
                }

                Console.WriteLine($"Encrypted text: {string.Join(" ", encryptedText)}");

                for (int i = 0; i < encryptedText.Count; i++)
                {
                    var value = encryptedText[i];
                    var decryptedLetter = allowedSymbols.First(x => x.Value == int.Parse(encryptedText[i])).Key;
                    decryptedText.Append(decryptedLetter);
                }

                Console.WriteLine($"Decrypted text: {decryptedText.ToString().TrimEnd()}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
