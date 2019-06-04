using System;
using System.IO;

namespace ChangeSymbolA
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string newFileContent = string.Empty;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'a')
                {
                    newFileContent += '_';
                }
                else
                {
                    newFileContent += text[i];
                }
            }
            File.WriteAllText("C:\\Users\\User\\Desktop\\test.txt", newFileContent);
        }
    }
}
