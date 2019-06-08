using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] matrix = new int[10, 10];
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                matrix[i, j] = 10 * i + j;
            }
        }
    }
}
