using System;

namespace Combinations
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int[] values = new int[] { 0, 1, 2 };
            int i = 1;

            do
            {
                Console.WriteLine(i++ + ": " + values[0] + "," + values[1] + "," + values[2]);
            }
            while (Next(5, values));
        }

        public static bool Next(int n, int[] values)
        {
            values[values.Length - 1]++;

            for (int i = values.Length - 1; i > 0; i--)
            {
                if (values[i] >= n - (values.Length - i) + 1)
                {
                    values[i - 1]++;
                }
            }

            if (values[0] > n - values.Length)
            {
                return false;
            }

            for (int i = 1; i < values.Length; i++)
            {
                if (values[i] >= n - (values.Length - i) + 1)
                {
                    values[i] = values[i - 1] + 1;
                }
            }

            return true;
        }
    }
}
