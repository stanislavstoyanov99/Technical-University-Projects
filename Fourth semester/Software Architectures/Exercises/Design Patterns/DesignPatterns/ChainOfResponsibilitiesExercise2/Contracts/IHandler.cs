namespace ChainOfResponsibilitiesExercise2.Contracts
{
    public interface IHandler
    {
        void SetNextChain(IHandler nextChain);

        void Dispense(Currency currency);
    }
}
