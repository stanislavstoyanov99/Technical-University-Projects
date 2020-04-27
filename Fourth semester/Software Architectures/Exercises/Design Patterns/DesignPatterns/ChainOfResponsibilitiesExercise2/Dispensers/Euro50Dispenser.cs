namespace ChainOfResponsibilitiesExercise2.Dispensers
{
    using System;

    using ChainOfResponsibilitiesExercise2.Contracts;
    using ChainOfResponsibilitiesExercise2.Messages;

    public class Euro50Dispenser : IHandler
    {
        private IHandler chain;

        private const int BanknoteSize = 50;

        public void SetNextChain(IHandler nextChain)
        {
            this.chain = nextChain;
        }

        public void Dispense(Currency currency)
        {
            if (currency.Amount >= 50)
            {
                int value = currency.Amount / 50;
                int remainder = currency.Amount % 50;
                string message = string.Format(UserMessages.DispensingMessage, value, BanknoteSize);

                Console.WriteLine(new string('*', message.Length));
                Console.WriteLine(message);
                Console.WriteLine(new string('*', message.Length));

                if (remainder != 0)
                {
                    this.chain.Dispense(new Currency(remainder));
                }
            }
            else if (chain != null)
            {
                this.chain.Dispense(currency);
            }
        }
    }
}
