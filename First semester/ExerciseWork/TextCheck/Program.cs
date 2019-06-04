using System;
using System.IO;

namespace textCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = File.ReadAllLines("file.txt");

            Console.WriteLine(text);

            char[] symbols = new char[text.Length];
            for (int i = 0; i < text.Length; i++)
            {
                symbols[i] = text[i];
            }
            for (int i = symbols.Length - 1; i >= 0; i--)
            {
                var maxIdx = i;
                for (int j = 0; j < i; j++)
                {
                    if (symbols[maxIdx] < symbols[j])
                    {
                        maxIdx = j;
                    }
                }

                char temp = symbols[i];
                symbols[i] = symbols[maxIdx];
                symbols[maxIdx] = temp;
            }
        }
    }
}
