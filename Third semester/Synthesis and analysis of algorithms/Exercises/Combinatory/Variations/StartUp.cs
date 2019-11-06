using System;

namespace Variations
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int[] values = new int[3];
            int i = 1;

            do
            {
                Console.WriteLine(i++ + ": " + values[0] + "," + values[1] + "," + values[2]);
            }
            while (Next(3, values));
        }
        
        // Variations with repetition
        public static bool Next(int n, int[] values)
        {
            int length = values.Length;

            values[length - 1]++; // set 0, 0, 1

            for (int i = length - 1; i > 0; i--)
            {
                if (values[i] >= n)
                {
                    values[i] = 0;
                    values[i - 1]++;
                }
            }

            return values[0] < n;
        }
    }
}
