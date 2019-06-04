using System;

namespace bubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new decimal[] { 5, 8, 1, 6, 2 };
            BubbleSort(array);

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        static void BubbleSort(decimal[]array)
        {
            bool isSorted = true;
            do
            {
                isSorted = true;
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i - 1] > array[i])
                    {
                        //Размяна на стойностите на две променливи
                        isSorted = false;
                        var temp = array[i];
                        array[i] = array[i - 1];
                        array[i - 1] = temp;
                    }
                }
            }
            while (!isSorted);
        }
    }
}
