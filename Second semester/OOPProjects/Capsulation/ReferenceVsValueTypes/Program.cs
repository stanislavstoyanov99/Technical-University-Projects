using System;

namespace ReferenceVsValueTypes
{
    class Program
    {
        public static int Add(int a, int b)
        {
            a = 4;
            return a + b;
        }

        public static void Change(int[] arr)
        {
            arr[0] = 9;
        }

        public static void Create(out int[] arr)
        {
            arr = new int[] { 1, 1, 1 };
        }

        static void Main(string[] args)
        {
            int a = 5;
            int b = 6;
            int result = Add(a, b); // result = 10, a =5, b = 6; if ref is included, variable a in Main method will be 4

            int[] arr = new int[] { 1, 1, 1 };
            Change(arr);
            Console.WriteLine(arr[0]);

            int[] secondArray;
            Create(out secondArray);
        }
    }
}
