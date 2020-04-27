namespace IteratorExercise1.Contracts
{
    public interface IAbstractCollection<T>
    {
        Iterator<T> CreateIterator();
    }
}
