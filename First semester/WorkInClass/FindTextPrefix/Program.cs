using System;
using System.IO;

namespace FindTextPrefix
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "E:\\ТУ - програмиране\\WorkInClass\\FindTextPrefix\\bin\\Debug\\file.txt";
            string [] names = File.ReadAllLines(path);

            int counter = 0;
            string prefix = "Ivan";
            for (int i = 0; i < names.Length; i++)
            {
                bool equal = true;
                for (int k = 0; k < prefix.Length; k++)
                {
                    if (names [i][k] == prefix[k])
                    {
                        counter++;
                        equal = false;
                        break;
                    }
                    if (equal)
                    {
                        Console.WriteLine(names[i]);
                    }
                }
            }

        }
    }
}
