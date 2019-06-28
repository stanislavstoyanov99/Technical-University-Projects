using System;

namespace GenericDelegates
{
    class Program
    {
        public static void Transform<T>(T[] values, Func<T, T> transformer)
        {
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = transformer(values[i]);
            }
        }

        public static int SquareTransformer(int x) { return x * x; }

        static void Main()
        {
            int[] intArr = { 1, 2, 3 };
            Func<int, int> transformer = SquareTransformer;

            Transform(intArr, transformer);
            foreach (var i in intArr)
            {
                Console.WriteLine(i);
            }
        }
    }
}
