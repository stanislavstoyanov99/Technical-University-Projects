namespace ChainOfResponsibilitiesExercise2
{
    public class Currency
    {
        public Currency(int amount)
        {
            this.Amount = amount;
        }

        public int Amount { get; private set; }
    }
}
