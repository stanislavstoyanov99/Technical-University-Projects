using System;

namespace ArrayExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] array = new int[100];
            //for (int count = 1; count <= 100; count++)
            //{
            //    array[count] = count;
            //}
            //for (int i = 1; i <= 100; i++)
            //{
            //    Console.WriteLine(array);
            //}

            //string input = Console.ReadLine();
            //for (int letterIndex = 0; letterIndex < input.Length; letterIndex++)
            //{
            //    char letter = input[letterIndex];
            //    Console.WriteLine(letter);
            //}

        }

        static int FindIndex(int[] arr, int val)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == val)
                {
                    return i;
                }
                else
                {
                    return -1;
                }
            }
        }
    }
}
