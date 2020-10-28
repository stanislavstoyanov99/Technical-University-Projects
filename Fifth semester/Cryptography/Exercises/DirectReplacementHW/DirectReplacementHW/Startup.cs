namespace DirectReplacementHW
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    // This program is an algorithm for direct replacement - homework page 17
    public class Startup
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
                {"\"", 39 }, {"№", 36 }, {"-", 37 }, {"Ъ", 38 },
            };

            Console.Write("Write input text for encryption: ");
            var inputText = Console.ReadLine();

            if (inputText.Length > 300)
            {
                Console.WriteLine("The input text should not be more than 300 symbols.");
                return;
            }

            var encryptedTextWithoutInterval = new List<string>();
            var decryptedTextWithoutInterval = new StringBuilder();

            var encryptedTextWithInterval = new List<string>();
            var decryptedTextWithInterval = new StringBuilder();

            try
            {
                encryptedTextWithoutInterval = EncryptMessageWithoutInterval(allowedSymbols, inputText, encryptedTextWithoutInterval);
                Console.WriteLine($"Encrypted text without intervals: {string.Join("", encryptedTextWithoutInterval)}");

                encryptedTextWithInterval = EncryptMessageWithInterval(allowedSymbols, inputText, encryptedTextWithInterval);
                Console.WriteLine($"Encrypted text with intervals: {string.Join("", encryptedTextWithInterval)}");

                Console.WriteLine(new string('-', 30));

                decryptedTextWithoutInterval = DecryptMessageWihoutInterval(allowedSymbols, encryptedTextWithoutInterval, decryptedTextWithoutInterval);
                Console.WriteLine($"Decrypted text without intervals: {decryptedTextWithoutInterval.ToString().TrimEnd()}");

                decryptedTextWithInterval = DecryptMessageWithInterval(allowedSymbols, encryptedTextWithInterval, decryptedTextWithInterval);
                Console.WriteLine($"Decrypted text with intervals: {decryptedTextWithInterval.ToString().TrimEnd()}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static StringBuilder DecryptMessageWihoutInterval(Dictionary<string, int> allowedSymbols, List<string> encryptedText, StringBuilder decryptedText)
        {
            for (int i = 0; i < encryptedText.Count; i++)
            {
                var value = encryptedText[i];

                if (value != " ")
                {
                    var decryptedLetter = allowedSymbols.First(x => x.Value == int.Parse(encryptedText[i])).Key;
                    decryptedText.Append(decryptedLetter);
                }
                else
                {
                    decryptedText.Append(" ");
                }
            }

            return decryptedText;
        }

        private static StringBuilder DecryptMessageWithInterval(Dictionary<string, int> allowedSymbols, List<string> encryptedText, StringBuilder decryptedText)
        {
            for (int i = 0; i < encryptedText.Count; i++)
            {
                var value = encryptedText[i];

                var decryptedLetter = allowedSymbols.First(x => x.Value == int.Parse(encryptedText[i])).Key;
                decryptedText.Append(decryptedLetter);
            }

            return decryptedText;
        }

        private static List<string> EncryptMessageWithoutInterval(Dictionary<string, int> allowedSymbols, string inputText, List<string> encryptedText)
        {
            for (int i = 0; i < inputText.Length; i++)
            {
                if (allowedSymbols.ContainsKey(inputText[i].ToString()))
                {
                    var encryptedCode = 0;

                    if (!char.IsWhiteSpace(inputText[i]))
                    {
                        encryptedCode = allowedSymbols.First(x => x.Key == inputText[i].ToString()).Value;
                        encryptedText.Add(encryptedCode.ToString());
                    }
                    else
                    {
                        encryptedText.Add(" ");
                    }
                }
                else
                {
                    throw new ArgumentException($"The letter {inputText[i]} in the input text does not exist in the allowed symbols.");
                }
            }

            return encryptedText;
        }

        private static List<string> EncryptMessageWithInterval(Dictionary<string, int> allowedSymbols, string inputText, List<string> encryptedText)
        {
            for (int i = 0; i < inputText.Length; i++)
            {
                if (allowedSymbols.ContainsKey(inputText[i].ToString()))
                {
                    var encryptedCode = allowedSymbols.First(x => x.Key == inputText[i].ToString()).Value;
                    encryptedText.Add(encryptedCode.ToString());
                }
                else
                {
                    throw new ArgumentException($"The letter {inputText[i]} in the input text does not exist in the allowed symbols.");
                }
            }

            return encryptedText;
        }
    }
}
