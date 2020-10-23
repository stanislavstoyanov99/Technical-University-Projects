namespace MultiAlphabeticSubstitution
{
    using System;
    using System.Linq;
    using System.Text;

    public class Startup
    {
        // This program is an algorithm for multi alphabetic substitution - example 2.4 - page 19 from the guide
        public static void Main()
        {
            var bulgarianAlphabet = Enumerable.Range('А', 'Я' - 'А' + 1)
                .Select(i => ((char)i).ToString())
                .Where(i => i != "Ы" && i != "Э")
                .ToArray();

            var allowedSymbols = string.Join("", bulgarianAlphabet);

            Console.Write("Write input text for encryption: ");
            var inputText = Console.ReadLine();

            Console.Write("Write crypto key: ");
            var cryptoKey = Console.ReadLine();

            try
            {
                for (int i = 0; i < cryptoKey.Length; i++)
                {
                    var isCryptoKeyValid = allowedSymbols.Contains(cryptoKey[i]);

                    if (!isCryptoKeyValid)
                    {
                        throw new ArgumentException("Crypto key is not valid. It should consist letters from allowed ones.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            if (inputText.Length > 300)
            {
                Console.WriteLine("The input text should not be more than 300 symbols.");
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
                        var currentLetterIndex = allowedSymbols.IndexOf(currentLetter) + 1;

                        var cryptoKeyIndex = CheckIfKeyIsLooped(allowedSymbols, cryptoKey, i);

                        var encryptedIndex = cryptoKeyIndex + currentLetterIndex;

                        if (encryptedIndex > allowedSymbols.Length)
                        {
                            encryptedIndex -= allowedSymbols.Length;
                        }

                        encryptedText.Append(allowedSymbols[encryptedIndex - 1].ToString());
                    }
                    else
                    {
                        throw new ArgumentException("The letter in the input text does not exist in the allowed symbols.");
                    }
                }

                Console.WriteLine($"Encrypted text: {encryptedText}");

                for (int i = 0; i < encryptedText.Length; i++)
                {
                    var currentLetterIndex = allowedSymbols.IndexOf(encryptedText[i]) + 1;

                    var cryptoKeyIndex = CheckIfKeyIsLooped(allowedSymbols, cryptoKey, i);

                    var decryptedIndex = currentLetterIndex - cryptoKeyIndex;

                    if (decryptedIndex <= 0)
                    {
                        decryptedIndex = allowedSymbols.Length - Math.Abs(decryptedIndex);
                    }

                    decryptedText.Append(allowedSymbols[decryptedIndex - 1].ToString());
                }

                Console.WriteLine($"Decrypted text: {decryptedText}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static int CheckIfKeyIsLooped(string allowedSymbols, string cryptoKey, int i)
        {
            var cryptoKeyIndex = 0;

            if (i >= cryptoKey.Length)
            {
                cryptoKeyIndex = allowedSymbols.IndexOf(cryptoKey[i % cryptoKey.Length]) + 1;
            }
            else
            {
                cryptoKeyIndex = allowedSymbols.IndexOf(cryptoKey[i]) + 1;
            }

            return cryptoKeyIndex;
        }
    }
}
