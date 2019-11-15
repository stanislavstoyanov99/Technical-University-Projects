using System;
using System.Threading;

namespace FindMaxElementInArray
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3 };

            int[] resArray = new int[3];
            Thread[] threadArray = new Thread[3];

            int count = array.Length / 3;

            for (int i = 0; i < 3; i++)
            {
                Thread thread = new Thread((o) =>
                {
                    int n = (int)o;
                    
                    int leftBoundary = n * count;
                    int rightBoundary = (n + 1) * count;

                    resArray[n] = FindMaxElementInArray(array, leftBoundary, rightBoundary);
                });

                threadArray[i] = thread;

                thread.Start(i);
            }

            for (int j = 0; j < 3; j++)
            {
                threadArray[j].Join();
            }

            FindMaxElementInArray(resArray, 0, resArray.Length);
        }

        public static int FindMaxElementInArray(int[] array, int leftBoundary, int rightBoundary)
        {
            int max = array[0];

            for (int i = leftBoundary; i < rightBoundary; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            return max;
        }
    }
}
