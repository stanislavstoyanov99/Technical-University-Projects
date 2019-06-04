using System;

namespace sortArraySecondWay
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 29, 72, 98, 13, 87, 66, 52, 51, 36 };

            for (int i = array.Length; i > 0; i--)
            {
                int index = i;
                for (int k = i - 1; k >= 0; k--)
                {
                    if (array[i] > array[k])
                    {
                        index = i;
                    }
                }
                int temp = array[i];
                array[i] = array[index];
                array[index] = temp;
            }
        }
    }
}
