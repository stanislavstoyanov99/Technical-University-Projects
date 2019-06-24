using System;

namespace DelegateExample
{
    class Program
    {
        static int Square(int x)
        {
            return x * x;
        }

        static void Main(string[] args)
        {
            int[] values = { 1, 2, 3 };
            Util.Transformer(values, Square);

            foreach (var item in values)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }

    public delegate int Transformer(int x);

    public class Util
    {
        public static void Transformer(int[] values, Transformer t)
        {
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = t(values[i]);
            }
        }
    }
}
