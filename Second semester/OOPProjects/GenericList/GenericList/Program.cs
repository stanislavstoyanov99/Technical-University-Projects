using System;
using System.Collections.Generic;

namespace GenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> list = new GenericList<int>();
            for (int i = 0; i <= 10; i++)
            {
                list.AddHead(i);
            }

            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }

    public class GenericList<T>
    {
        private class Node
        {
            public Node Next { get; set; }
            public T Data { get; set; }

            public Node(T t)
            {
                Next = null;
                Data = t;
            }
        }

        private Node head;
        public GenericList()
        {
            head = null;
        }

        public void AddHead(T t)
        {
            Node n = new Node(t);
            n.Next = head;
            head = n;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node current = head;

            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }
}
