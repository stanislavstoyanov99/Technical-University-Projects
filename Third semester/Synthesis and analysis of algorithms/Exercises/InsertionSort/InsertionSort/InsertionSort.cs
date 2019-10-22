namespace SortAlgorithms
{
    public class InsertionSort
    {
        public void Sort(int[] array)
        {
            int length = array.Length;

            for (int i = 1; i < length; i++)
            {
                int key = array[i];
                int j = i - 1;

                while (j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j -= 1;
                }

                array[j + 1] = key;
            }
        }
    }
}
