namespace DIP.ConcreteModels
{
    using DIP.Models;

    public class MeatEntree : Entree
    {
        public MeatEntree()
        {
            Name = "Starter with meat";
            Calories = 200;
            IsColdPrepared = false;
        }
    }
}
