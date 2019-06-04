using System;
using System.IO;

namespace SortFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = File.ReadAllLines("file.txt");

            for (int i = array.Length; i > 0; i--)
            {
                int index = i;
                for (int k = i - 1; k >= 0; k--)
                {
                    if (array[i] > array[k])
                    {
                        index = i;
                    }
                }
                int temp = element[i];
                element[i] = element[index];
                element[index] = temp;
            }
        }
    }
}
