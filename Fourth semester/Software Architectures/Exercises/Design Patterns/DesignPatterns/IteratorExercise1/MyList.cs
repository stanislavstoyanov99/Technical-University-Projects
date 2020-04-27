namespace IteratorExercise1
{
    using System;

    using IteratorExercise1.Contracts;

    public class MyList<T> : IAbstractCollection<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public MyList()
        {
            this.head = null;
            this.tail = null;
        }

        public Node<T> GetCurrentNode(int index)
        {
            Node<T> current = this.head;
            int count = 0;

            while (current != null)
            {
                if (count == index)
                {
                    return current;
                }

                count++;
                current = current.Next;
            }

            // If nothing is found, return nothing
            return null;
        }

        public Node<T> GetHead()
        {
            if (head != null)
            {
                return this.head;
            }
            else
            {
                return null;
            }
        }

        public int GetCount()
        {
            int counter = 0;
            var node = this.head;

            while (node != null)
            {
                counter++;
                node = node.Next;
            }

            return counter;
        }

        public Node<T> Add(T item)
        {
            if (head == null)
            {
                head = new Node<T>
                {
                    Value = item
                };

                tail = head;
            }
            else
            {
                Node<T> newNode = new Node<T>
                {
                    Value = item
                };

                tail.Next = newNode;
                tail = newNode;
            }

            return tail;
        }

        public Iterator<T> CreateIterator()
        {
            return new Iterator<T>(this);
        }

        // From exercise definition
        public void PrintList()
        {
            var node = head;

            while (node != null)
            {
                Console.Write($"{node.Value} ");
                node = node.Next;
            }
        }
    }
}
