namespace DIP.ConcreteModels
{
    using DIP.Models;

    public class VegaterianEntree : Entree
    {
        public VegaterianEntree()
        {
            Name = "Starter without meat";
            Calories = 100;
            IsColdPrepared = true;
        }
    }
}
