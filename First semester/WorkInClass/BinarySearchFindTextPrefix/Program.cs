using System;
using System.IO;

namespace BinarySearchFindTextPrefix
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "E:\\ТУ - програмиране\\WorkInClass\\BinarySearchFindTextPrefix\\bin\\Debug\\file.txt";
            string[] names = File.ReadAllLines(path);
            string prefix = "Ivan";

            int counter = 0;

            for (int i = 0; i < names.Length; i++)
            {
                bool equal = true;
                for (int k = 0; k < prefix.Length; k++)
                {
                    if (names[i][k] == prefix[k])
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
