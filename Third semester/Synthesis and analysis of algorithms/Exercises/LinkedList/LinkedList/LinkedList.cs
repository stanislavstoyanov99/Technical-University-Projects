using System;

namespace LinkedList
{
    public class LinkedList<T>
    {
        private Node<T> head;

        public void InsertFront(T newData)
        {
            Node<T> newNode = new Node<T>(newData);
            newNode.next = head;
            head = newNode;
        }

        public void InsertLast(T newData)
        {
            Node<T> newNode = new Node<T>(newData);

            if (head == null)
            {
                head = newNode;
                return;
            }

            Node<T> lastNode = GetLastNode();
            lastNode.next = newNode;
        }

        public void InsertAfter(Node<T> previousNode, T newData)
        {
            if (previousNode == null)
            {
                throw new InvalidNodeValueException();
            }

            Node<T> newNode = new Node<T>(newData);
            newNode.next = previousNode.next;
            previousNode.next = newNode;
        }

        public void PrintNodes()
        {
            Node<T> current = head;

            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
        }

        private Node<T> GetLastNode()
        {
            Node<T> temp = head;

            while (temp.next != null)
            {
                temp = temp.next;
            }

            return temp;
        }
    }
}
