using System;

namespace SequenceExample
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 2; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(i * -1);
                }
            }
        }
    }
}
