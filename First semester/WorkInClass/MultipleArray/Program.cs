using System;

class Program
{
    static void Main(string[] args)
    {
        int[][] multipleArray = new int[10][];
        for (int i = 0; i < 10; i++)
        {
            multipleArray[i] = new int[i + 1];

            for (int j = 0; j < i + 1; j++)
            {
                multipleArray[i][j] = 10 * i + j;
            }
        }

    }
}
