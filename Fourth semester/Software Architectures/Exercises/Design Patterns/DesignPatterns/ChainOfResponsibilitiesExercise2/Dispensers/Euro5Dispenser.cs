namespace ChainOfResponsibilitiesExercise2.Dispensers
{
    using System;

    using ChainOfResponsibilitiesExercise2.Contracts;
    using ChainOfResponsibilitiesExercise2.Messages;

    public class Euro5Dispenser : IHandler
    {
        private IHandler chain;

        private const int BanknoteSize = 5;

        public void SetNextChain(IHandler nextChain)
        {
            this.chain = nextChain;
        }

        public void Dispense(Currency currency)
        {
            if (currency.Amount >= 5)
            {
                int value = currency.Amount / 5;
                int remainder = currency.Amount % 5;
                string message = string.Format(UserMessages.DispensingMessage, value, BanknoteSize);

                Console.WriteLine(new string('*', message.Length));
                Console.WriteLine(message);
                Console.WriteLine(new string('*', message.Length));

                if (remainder != 0)
                {
                    this.chain.Dispense(new Currency(remainder));
                }
            }
            else if (currency.Amount < BanknoteSize) // This check is made in order to ensure that the ATM can handle request when user inputs value < 5
            {
                Console.WriteLine(UserMessages.InvalidDispensingMessage);
            }
        }
    }
}
