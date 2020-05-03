namespace DIP.Factories
{
    using System.Collections.Generic;

    using DIP.Models;
    using DIP.Contracts;
    using DIP.ConcreteModels;

    public class MeatFactory : IMealFactory
    {
        public List<Dessert> CreateDessert()
        {
            var desserts = new List<Dessert>
            {
                new BasicLowCarbDessert(),
                new BasicHighCarbDessert()
            };

            return desserts;
        }

        public Entree CreateEntree()
        {
            return new MeatEntree();
        }

        public MainCourse CreateMainCourse()
        {
            return new MeatMainCourse();
        }
    }
}
