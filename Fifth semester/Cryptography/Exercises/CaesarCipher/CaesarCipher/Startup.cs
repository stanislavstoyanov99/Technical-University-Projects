namespace CaesarCipher
{
    using System;
    using System.Linq;
    using System.Text;

    public class Startup
    {
        public static void Main(string[] args)
        {
            var bulgarianAlphabet = Enumerable.Range('А', 'Я' - 'А' + 1).Select(i => ((char)i).ToString()).ToArray();
            var englishAlphabet = Enumerable.Range('A', 'Z' - 'A' + 1).Select(i => ((char)i).ToString()).ToArray();
            var digits = Enumerable.Range(0, 10).Select(i => i.ToString()).ToArray();
            string[] specialSymbols = { " ", ".", ",", ":", "/" };

            var allowedSymbols = string.Join("", bulgarianAlphabet)
                + ""
                + string.Join("", englishAlphabet)
                + ""
                + string.Join("", digits)
                + ""
                + string.Join("", specialSymbols);

            Console.Write("Write input text for encryption: ");
            var inputText = Console.ReadLine();

            if (inputText.Length > 80)
            {
                Console.WriteLine("The input text should not be more than 80 symbols.");
                return;
            }

            var encryptedText = new StringBuilder();
            var decryptedText = new StringBuilder();

            try
            {
                for (int i = 0; i < inputText.Length; i++)
                {
                    var doesItExist = allowedSymbols.Any(x => x == inputText[i]);

                    if (doesItExist)
                    {
                        var currentLetter = allowedSymbols.First(x => x == inputText[i]);
                        var newPosition = allowedSymbols.IndexOf(currentLetter) + 3;
                        encryptedText.Append(allowedSymbols[newPosition]);
                    }
                    else
                    {
                        throw new ArgumentException("The letter in the input text does not exist in the allowed symbols");
                    }
                }

                Console.WriteLine($"Encrypted text: {encryptedText}");

                for (int i = 0; i < encryptedText.Length; i++)
                {
                    var oldPosition = allowedSymbols.IndexOf(encryptedText[i]) - 3;
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
