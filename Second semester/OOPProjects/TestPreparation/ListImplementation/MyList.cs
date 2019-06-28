using System;
using System.Collections.Generic;
using System.Text;

namespace ListImplementation
{
    public class MyList<T>
    {
        private T[] array = new T[1];
        private int lastIndex = 0;

        public T Add(T element)
        {
            if (array.Length >= lastIndex)
            {
                var newArray = new T[array.Length * 2];
                Array.Copy(array, newArray, lastIndex);
                array = newArray;
            }

            array[lastIndex] = element;
            lastIndex++;

            return element;
        }
    }
}
