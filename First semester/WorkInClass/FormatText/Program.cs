using System;
using System.IO;

namespace FormatText
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileSource = Console.ReadLine();
            var fileDestination = Console.ReadLine();

            var contentSource = File.ReadAllText(fileSource);

            string contentResult = string.Empty;
            int d = 0;

            for (int i = 0; i < contentSource.Length; i++)
            {
                contentResult += contentSource[i];
                d++;

                if (d == 80)
                {
                    contentResult += Environment.NewLine;
                    d = 0;
                }
            }

            File.WriteAllText(fileDestination, contentResult);
        }
    }
}
