using System;

class Program
{
    static void Main(string[] args)
    {
        int[][] jaggedArray = new int[2][];
        jaggedArray[0] = new int[3] { 1, 2, 3};
        jaggedArray[1] = new int[1] { 4 };
        foreach(var arr in jaggedArray)
        {
            foreach (var element in arr)
            {
                Console.Write($"{element} ");
            }
            Console.WriteLine();
        }
    }
}
