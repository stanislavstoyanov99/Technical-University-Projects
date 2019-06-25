using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    public class LinkedList<T>
    {
        public class Node
        {
            public Node Prev, Next;
            public T Value;

            public Node(T value)
            {
                Value = value;
            }
        }

        private Node head, tail;

        public LinkedList()
        {
            head = tail = null;
        }

        public Node AddFirst(T value)
        {
            var node = new Node(value);
            if (head == null)
            {
                head = tail = node;
            }
            else
            {
                node.Next = head;
                head.Prev = node;
                head = node;
            }

            return node;
        }

        public Node AddLast (T value)
        {
            var node = new Node(value);
            if (head == null)
            {
                head = tail = node;
            }
            else
            {
                //TODO
            }
        }

        public Node Find(T value)
        {
            Node current = head;

            // Обхождане на свързан списък в търсене на определен елемент - value
            while (current != null)
            {
                if (current.Value.Equals(value))
                {
                    return current;
                }
                current = current.Next;
            }

            return null;
        }

        public Node AddBefore(Node node, T value)
        {
            var newNode = new Node(value);
            newNode.Prev = node.Prev;
            newNode.Next = node;
            node.Prev = newNode;
            newNode.Prev.Next = newNode;
            return newNode;
        }

        public Node AddAfter(Node node, T value)
        {
            var newNode = new Node(value);
            // TODO
            return newNode;
        }

        public Node Remove(Node node, T value)
        {
            // TODO
        }
    }
}
