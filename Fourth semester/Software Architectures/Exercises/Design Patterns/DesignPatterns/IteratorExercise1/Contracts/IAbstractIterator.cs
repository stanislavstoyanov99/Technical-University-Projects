namespace IteratorExercise1.Contracts
{
    public interface IAbstractIterator<T>
    {
        Node<T> First();

        Node<T> Next();

        bool IsDone { get; }

        Node<T> CurrentItem { get; }
    }
}
