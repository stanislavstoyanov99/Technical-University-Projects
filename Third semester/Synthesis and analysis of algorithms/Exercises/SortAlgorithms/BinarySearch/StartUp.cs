using System;

namespace BinarySearch
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 5, 6, 10, 12};

            int foundNumber = BinarySearch(numbers, 12);

            Console.WriteLine(foundNumber);
        }

        public static int BinarySearch(int[] array, int numberToFind)
        {
            int leftBoundary = 0;
            int rightBoundary = array.Length - 1;

            while (leftBoundary <= rightBoundary)
            {
                int middleIndex = (leftBoundary + rightBoundary) / 2;

                if (array[middleIndex] < numberToFind)
                {
                    leftBoundary = middleIndex + 1;
                }
                else if (array[middleIndex] > numberToFind)
                {
                    rightBoundary = middleIndex - 1;
                }
                else
                {
                    return array[middleIndex];
                }
            }

            return -1;
        }
    }
}
