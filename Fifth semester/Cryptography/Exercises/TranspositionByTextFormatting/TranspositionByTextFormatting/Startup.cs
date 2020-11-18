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
                    encryptedText = EncryptMessage(allowedSymbols, encryptedText, inputText, cryptoKey);
                    cryptogramsCount++;

                    Console.WriteLine(new string('-', 50));

                    Console.WriteLine($"Encrypted text: {encryptedText}");
                    Console.WriteLine($"Blocks: {cryptoKey.Length}; Symbols count in each block: {encryptedText.Length / cryptoKey.Length}");
                    Console.WriteLine(new string('-', 50));

                    counter++;
                    encryptedText.Clear();
                }

                Console.WriteLine($"{cryptogramsCount} cryptograms made! Please provide new crypto key.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static StringBuilder EncryptMessage(
            string allowedSymbols,
            StringBuilder encryptedText,
            string inputText,
            string cryptoKey)
        {
            var rows = inputText.Length / cryptoKey.Length;
            var cols = cryptoKey.Length;
            string[,] matrix = InitializeMatrix(inputText, cryptoKey, rows, cols);

            var orderedCryptoKeyDictionary = SetOrderedDictionary(allowedSymbols, cryptoKey);

            var modifiedCryptoKey = string.Empty;
            for (int i = 0; i < cryptoKey.Length; i++)
            {
                var currSymbol = cryptoKey[i].ToString();
                var currIndex = orderedCryptoKeyDictionary.Values.ToList().IndexOf(currSymbol) + 1;
                modifiedCryptoKey += currIndex.ToString();
            }
            modifiedCryptoKey = string.Concat(modifiedCryptoKey.OrderBy(x => x));

            var matrixDictionary = SetMatrixDictionary(cryptoKey, matrix, orderedCryptoKeyDictionary);

            for (int i = 0; i < cryptoKey.Length; i++)
            {
                var currIndex = int.Parse(modifiedCryptoKey[i].ToString());
                var currBlock = matrixDictionary[currIndex];

                foreach (var symbol in currBlock)
                {
                    encryptedText.Append(symbol);
                }
            }

            return encryptedText;
        }

        private static Dictionary<int, List<string>> SetMatrixDictionary(
            string cryptoKey,
            string[,] matrix,
            Dictionary<int, string> orderedCryptoKeyDictionary)
        {
            var matrixDictionary = new Dictionary<int, List<string>>();

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                var currSymbol = cryptoKey[col].ToString();
                var currIndеx = orderedCryptoKeyDictionary.Values.ToList().IndexOf(currSymbol) + 1;
                matrixDictionary[currIndеx] = new List<string>();

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    matrixDictionary[currIndеx].Add(matrix[row, col]);
                }
            }

            return matrixDictionary;
        }

        private static Dictionary<int, string> SetOrderedDictionary(string allowedSymbols, string cryptoKey)
        {
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

            return orderedCryptoKeyDictionary;
        }

        private static string[,] InitializeMatrix(string inputText, string cryptoKey, int rows, int cols)
        {
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

            return matrix;
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
