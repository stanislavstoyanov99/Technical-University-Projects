using System;

namespace triangleFigure
{
    class Program
    {
        //Iterative way
        //static void Main(string[] args)
        //{
        //    for (int i = 9; i > 0; i--)
        //    {
        //        for (int k = i; k > 0; k--)
        //        {
        //            Console.Write(k);
        //        }
        //        Console.WriteLine();
        //    }
        //}

        //Recursive way
        static void Main(string[] args)
        {
            
        }
        public static void Print(int row, int col)
        {
            if (row == 0)
            {
                return;
            }
            else if (col == 0)
            {
                row--;
                col = row;
                Console.WriteLine();
            }
            Console.Write(col);
            Print(row, col - 1);
        }
    }
}
