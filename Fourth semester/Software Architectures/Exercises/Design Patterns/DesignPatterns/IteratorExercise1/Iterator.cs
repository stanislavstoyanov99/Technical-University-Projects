namespace IteratorExercise1
{
    using IteratorExercise1.Contracts;

    public class Iterator<T> : IAbstractIterator<T>
    {
        private int current = 0;
        private readonly int step = 1;

        private readonly MyList<T> list;

        public Iterator(MyList<T> list)
        {
            this.list = list;
        }

        public Node<T> First()
        {
            return this.list.GetHead() as Node<T>;
        }

        public Node<T> Next()
        {
            this.current += step;
            if (!IsDone)
            {
                return this.list.GetCurrentNode(this.current) as Node<T>;
            }
            else
            {
                return null;
            }
        }

        public bool IsDone => this.current >= this.list.GetCount();

        public Node<T> CurrentItem => this.list.GetCurrentNode(this.current) as Node<T>;
    }
}
