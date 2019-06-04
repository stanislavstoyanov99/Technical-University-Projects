using System;

namespace money
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = int.Parse(Console.ReadLine());

        }
        static int Rest (int sum, int[]arr,int length)
        {
            if (length > 0)
            {

            }
            Rest(sum, arr, length - 1);
        }
    }
}
