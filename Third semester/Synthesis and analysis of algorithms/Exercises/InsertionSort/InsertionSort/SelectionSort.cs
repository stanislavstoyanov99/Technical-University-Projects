namespace SortAlgorithms
{
    public class SelectionSort
    {
        public void Sort(int[] array)
        {
            int length = array.Length;

            for (int i = length - 1; i > 0; i--)
            {
                int maxIndex = i;

                for (int j = i - 1; j > 0; j--)
                {
                    if (array[j] > array[maxIndex])
                    {
                        maxIndex = j;
                    }
                }

                int temp = array[maxIndex];
                array[maxIndex] = array[i];
                array[i] = temp;
            }
        }
    }
}
