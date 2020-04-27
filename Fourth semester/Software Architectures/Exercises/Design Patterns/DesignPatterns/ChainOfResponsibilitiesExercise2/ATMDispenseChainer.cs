namespace ChainOfResponsibilitiesExercise2
{
    using System;

    using ChainOfResponsibilitiesExercise2.Contracts;
    using ChainOfResponsibilitiesExercise2.Dispensers;
    using ChainOfResponsibilitiesExercise2.Messages;

    public class ATMDispenseChainer
    {
        public static void Main()
        {
            // Types of currency bills
            IHandler euro100dispenser = new Euro100Dispenser();
            IHandler euro50dispenser = new Euro50Dispenser();
            IHandler euro20dispenser = new Euro20Dispenser();
            IHandler euro10dispenser = new Euro10Dispenser();
            IHandler euro5dispenser = new Euro5Dispenser();

            // Set the chain of responsibility
            euro100dispenser.SetNextChain(euro50dispenser);
            euro50dispenser.SetNextChain(euro20dispenser);
            euro20dispenser.SetNextChain(euro10dispenser);
            euro10dispenser.SetNextChain(euro5dispenser);

            while (true)
            {
                Console.WriteLine("Enter amount to dispense || Enter 0 to exit from program");

                // Validate input so that user cannot request a string for example
                var input = Console.ReadLine();
                var result = int.TryParse(input, out int amount);

                if (!result)
                {
                    Console.WriteLine(UserMessages.InvalidInput);
                    continue;
                }

                if (amount == 0)
                {
                    Console.WriteLine("You have successfully exited the program.");
                    return;
                }

                // process the request
                euro100dispenser.Dispense(new Currency(amount));
            }
        }
    }
}
