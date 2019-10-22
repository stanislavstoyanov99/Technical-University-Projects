using System;

namespace SortAlgorithms
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Random r = new Random();
            var array = new int[10_000];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next();
            }

            var secondArray = new int[10_000];
            var thirdArray = new int[10_000];

            Array.Copy(array, secondArray, array.Length);
            Array.Copy(array, thirdArray, array.Length);

            // Insertion Sort
            var insertionSort = new InsertionSort();
            var d1 = DateTime.Now;
            insertionSort.Sort(array);
            var d2 = DateTime.Now;

            int totalTimeForInsertionSort = (d2 - d1).Milliseconds;

            // Selection Sort
            var selectionSort = new SelectionSort();
            d1 = DateTime.Now;
            selectionSort.Sort(secondArray);
            d2 = DateTime.Now;

            int totalTimeForSelectionSort = (d2 - d1).Milliseconds;

            // Bubble Sort
            var bubbleSort = new BubbleSort();
            d1 = DateTime.Now;
            bubbleSort.Sort(thirdArray);
            d2 = DateTime.Now;

            int totalTimeForBubbleSort = (d2 - d1).Milliseconds;

            PrintResult(totalTimeForInsertionSort, totalTimeForSelectionSort, totalTimeForBubbleSort);
        }

        public static void PrintResult(int firstTime, int secondTime, int thirdTime)
        {
            Console.WriteLine(firstTime);
            Console.WriteLine(secondTime);
            Console.WriteLine(thirdTime);
        }
    }
}
