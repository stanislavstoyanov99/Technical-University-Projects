namespace ShiftCharactersAlgorithm
{
    using System;
    using System.Linq;
    using System.Text;

    public class Startup
    {
        // This program is an algorithm for shifting characters
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
            var doublyEncryptedText = new StringBuilder();
            var decryptedText = new StringBuilder();
            var doublyDecryptedText = new StringBuilder();

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

                    Console.Write("New crypto key: ");
                    var newCryptoKey = Console.ReadLine();

                    Console.WriteLine(new string('-', 50));

                    encryptedText = EncryptMessage(encryptedText, inputText, cryptoKey);
                    cryptogramsCount++;              
                    decryptedText = DecryptMessage(decryptedText, encryptedText.ToString(), cryptoKey);

                    doublyEncryptedText = EncryptMessage(doublyEncryptedText, encryptedText.ToString(), newCryptoKey);
                    cryptogramsCount++;

                    // Make 2 steps of decryption, because there is a double encrypted text
                    doublyDecryptedText = DecryptMessage(doublyDecryptedText, doublyEncryptedText.ToString(), newCryptoKey);
                    doublyDecryptedText = DecryptMessage(doublyDecryptedText, doublyDecryptedText.ToString(), cryptoKey);

                    Console.WriteLine($"Encrypted text: {encryptedText}");
                    Console.WriteLine($"Total count of blocks: {encryptedText.Length / cryptoKey.Length}");
                    Console.WriteLine($"Decrypted text: {decryptedText}");
                    Console.WriteLine(new string('-', 50));
                    Console.WriteLine("Блокуване на вече получената криптограма:");
                    Console.WriteLine($"Doubly encrypted text: {doublyEncryptedText}");
                    Console.WriteLine($"Total count of blocks: {doublyEncryptedText.Length / newCryptoKey.Length}");
                    Console.WriteLine($"Doubly decrypted text: {doublyDecryptedText}");
                    Console.WriteLine(new string('-', 50));

                    counter++;
                    encryptedText.Clear();
                    decryptedText.Clear();
                    doublyEncryptedText.Clear();
                    doublyDecryptedText.Clear();
                }

                Console.WriteLine($"{cryptogramsCount} cryptograms made! Please provide new crypto key.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static StringBuilder DecryptMessage(StringBuilder output, string inputText, string newCryptoKey)
        {
            output.Clear();

            for (int i = 0; i < inputText.Length; i += newCryptoKey.Length)
            {
                var blockToDecrypt = inputText.Substring(i, newCryptoKey.Length);
                var decryptedBlock = new string[newCryptoKey.Length];

                for (int j = 0; j < newCryptoKey.Length; j++)
                {
                    var cryptoKeyIndex = int.Parse(newCryptoKey[j].ToString()) - 1;
                    var currentSymbol = blockToDecrypt[cryptoKeyIndex].ToString();
                    decryptedBlock[j] = currentSymbol;
                }

                foreach (var symbol in decryptedBlock)
                {
                    output.Append(symbol);
                }
            }

            return output;
        }

        private static StringBuilder EncryptMessage(StringBuilder output, string inputText, string cryptoKey)
        {
            inputText = ValidateInputText(inputText, cryptoKey);

            for (int i = 0; i < inputText.Length; i += cryptoKey.Length)
            {
                var blockToEncrypt = inputText.Substring(i, cryptoKey.Length);
                var encryptedBlock = new string[cryptoKey.Length];

                for (int j = 0; j < cryptoKey.Length; j++)
                {
                    var cryptoKeyIndex = int.Parse(cryptoKey[j].ToString()) - 1;
                    var currentSymbol = blockToEncrypt[j].ToString();
                    encryptedBlock[cryptoKeyIndex] = currentSymbol;
                }

                foreach (var symbol in encryptedBlock)
                {
                    output.Append(symbol);
                }
            }

            return output;
        }

        private static string ValidateInputText(string inputText, string cryptoKey)
        {
            var isCryptoKeyValid = inputText.Length % cryptoKey.Length == 0;

            if (!isCryptoKeyValid)
            {
                var remainder = inputText.Length % cryptoKey.Length;
                var totalSymbolsCount = inputText.Length + cryptoKey.Length - remainder;
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
