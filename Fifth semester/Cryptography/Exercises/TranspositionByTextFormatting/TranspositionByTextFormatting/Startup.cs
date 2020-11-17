namespace TranspositionByTextFormatting
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Startup
    {
        // This program is an algorithm for transposition by text formatting
        public static void Main()
        {
            var bulgarianAlphabet = Enumerable.Range('А', 'Я' - 'А' + 1)
                .Select(i => ((char)i).ToString())
                .Where(i => i != "Ы" && i != "Э")
                .ToArray();
            string[] specialSymbols = { " " };
            var digits = Enumerable.Range(0, 10).Select(i => i.ToString()).ToArray();

            var allowedSymbols = string.Join("", bulgarianAlphabet)
                + ""
                + string.Join("", specialSymbols)
                + ""
                + string.Join("", digits);

            var encryptedText = new StringBuilder();
            var decryptedText = new StringBuilder();

            int counter = 1;
            const int MAXIMUM_ATTEMPTS_ALLOWED = 2;

            try
            {
                var cryptogramsCount = 0;

                while (counter <= MAXIMUM_ATTEMPTS_ALLOWED)
                {
                    Console.Write("Write input text for encryption: ");
                    var inputText = Console.ReadLine();

                    Console.Write("Write crypto key: ");
                    var cryptoKey = Console.ReadLine();

                    inputText = ValidateInputText(inputText, cryptoKey);

                    var rows = inputText.Length / cryptoKey.Length;
                    var cols = cryptoKey.Length;
                    string[,] matrix = new string[rows, cols];

                    int symbolCounter = 0;
                    for (int row = 0; row < matrix.GetLength(0); row++)
                    {
                        for (int col = 0; col < matrix.GetLength(1); col++)
                        {
                            matrix[row, col] = inputText.Substring(symbolCounter, 1);
                            symbolCounter++;
                        }
                    }

                    var cryptoKeyDictionary = new Dictionary<int, string>();
                    for (int i = 0; i < cryptoKey.Length; i++)
                    {
                        var currIndex = allowedSymbols.IndexOf(cryptoKey[i]) + 1;
                        var currSymbol = allowedSymbols[currIndex - 1];
                        cryptoKeyDictionary[currIndex] = currSymbol.ToString();
                    }

                    var orderedCryptoKeyDictionary = cryptoKeyDictionary
                        .OrderBy(x => x.Key)
                        .ToDictionary(x => x.Key, y => y.Value);

                    var keyDictionary = new Dictionary<int, string>();
                    for (int i = 0; i < cryptoKey.Length; i++)
                    {
                        var currSymbol = cryptoKey[i].ToString();
                        var currSymbolIndex = allowedSymbols.IndexOf(currSymbol) + 1;

                        if (orderedCryptoKeyDictionary[currSymbolIndex] == currSymbol)
                        {
                            var newIndex = orderedCryptoKeyDictionary.Values.ToList().IndexOf(currSymbol) + 1;
                            keyDictionary[newIndex] = currSymbol;
                        }
                    }

                    var matrixDictionary = new Dictionary<int, List<string>>();
                    for (int i = 0; i < cryptoKey.Length; i++)
                    {
                        for (int col = 0; col < matrix.GetLength(1); col++)
                        {
                            var currSymbol = cryptoKey[i].ToString();
                            var currIndеx = keyDictionary.FirstOrDefault(x => x.Value == currSymbol).Key;
                            matrixDictionary[currIndеx] = new List<string>();

                            for (int row = 0; row < matrix.GetLength(0); row++)
                            {
                                matrixDictionary[currIndеx].Add(matrix[row, 0]);
                            }
                        }
                    }

                    // TODO -> finish algorithm
                    Console.WriteLine(new string('-', 50));

                    Console.WriteLine($"Encrypted text: {encryptedText}");
                    Console.WriteLine($"Decrypted text: {decryptedText}");
                    Console.WriteLine(new string('-', 50));

                    counter++;
                    encryptedText.Clear();
                    decryptedText.Clear();
                }

                Console.WriteLine($"{cryptogramsCount} cryptograms made! Please provide new crypto key.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static string ValidateInputText(string inputText, string cryptoKey)
        {
            var isCryptoKeyValid = inputText.Length % cryptoKey.Length == 0;

            if (!isCryptoKeyValid)
            {
                var remainder = inputText.Length % cryptoKey.Length;
                var totalSymbolsCount = inputText.Length + 5 - remainder;
                var symbolsToAdd = totalSymbolsCount - inputText.Length;

                for (int i = 0; i < symbolsToAdd; i++)
                {
                    inputText = inputText.Insert(inputText.Length, " ");
                }
            }

            return inputText;
        }
    }
}
