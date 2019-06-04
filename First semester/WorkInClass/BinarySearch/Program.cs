using System;

namespace binarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] array = new decimal []{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            decimal v = decimal.Parse(Console.ReadLine());

            int firstPosition = 3;
            int secondPosition = 8;
            Console.WriteLine(BinarySearchFirstWay(array, v, out firstPosition));
            Console.WriteLine(BinarySearchSecondWay(array, v, out secondPosition));
        }

        static bool BinarySearchFirstWay(decimal[] array, decimal v, out int position)
        {
            var start = 0;
            var end = array.Length - 1;
            for (int i = 0; i < array.Length; i++)
            {
                var mid = start + ((end - start) / 2);
                if (array[mid] == v)
                {
                    position = mid;
                    return true;
                }

                if (array[mid] > v)
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }
            position = -1;
            return false;
        }

        static bool BinarySearchSecondWay(decimal[] array, decimal v, out int position)
        {
            var start = 0;
            var end = array.Length - 1;

            while (start <= end)
            {
                var mid = start + (end - start) / 2;

                if (array[mid] == v)
                {
                    position = mid;
                    return true;
                }
                if (array[mid] > v)
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }

            position = -1;
            return false;
        }
    }
}
