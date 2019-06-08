using System;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        static void SelectionSort(decimal []array)
        {
            for (int i = 0; i < array.Length-1; i++)
            {
                int minIdx = i;
                for (int k = i + 1; k < array.Length; k++)
                {
                    if (array[k] < array[minIdx])
                    {
                        minIdx = k;
                    }
                }
                if (minIdx != i)//Трябва размяна
                {
                    var temp = array[minIdx];
                    array[minIdx] = array[i];
                    array[i] = temp;
                }
            }
        }
    }
}
