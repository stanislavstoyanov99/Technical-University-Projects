using System;

namespace sortArrayFirstWay
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 85, 12, 59, 45, 72, 51 };

            for (int i = 1; i < array.Length; i++)
            {
                for (int k = i; k > 0; k--)
                {
                    if (array[i] > array [k-1])
                    {
                        int temp = array[i];
                        array[i] = array[k - 1];
                        array[k - 1] = temp;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
    }
}
