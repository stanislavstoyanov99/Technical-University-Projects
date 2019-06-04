using System;
namespace recursionComb
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        static int Change(int n, int k, int [] arr)
        {
            if(arr[k] < n)
            {
                arr[k]++;
            }
            else
            {
                Change(n, k - 1, arr);
                arr[k] = 0;
            }
        }
    }
}
