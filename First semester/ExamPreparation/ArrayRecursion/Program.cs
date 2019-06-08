using System;


namespace arrayRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 5, 3, 8, 9, 3, 4, 5, 7, 1, 2, 4, 7 };
            string result = Recursive(array, 0);
            Console.WriteLine(result.Substring(0, result.Length - 2));
        }
        public static string Recursive(int [] array, int idx)
        {
            if (array.Length <= idx)
            {
                return "";
            }

            return array[idx] + ", " + Recursive(array, ++idx);
        }
    }
}
