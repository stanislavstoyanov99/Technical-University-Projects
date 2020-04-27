namespace ChainOfResponsibilitiesExercise2.Dispensers
{
    using System;

    using ChainOfResponsibilitiesExercise2.Contracts;
    using ChainOfResponsibilitiesExercise2.Messages;

    public class Euro20Dispenser : IHandler
    {
        private IHandler chain;

        private const int BanknoteSize = 20;

        public void SetNextChain(IHandler nextChain)
        {
            this.chain = nextChain;
        }

        public void Dispense(Currency currency)
        {
            if (currency.Amount >= 20)
            {
                int value = currency.Amount / 20;
                int remainder = currency.Amount % 20;
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
