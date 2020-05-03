namespace DIP.ConcreteModels
{
    using DIP.Models;

    public class VeganEntree : Entree
    {
        public VeganEntree()
        {
            Name = "Starter without animal products";
            Calories = 50;
            IsColdPrepared = true;
        }
    }
}
