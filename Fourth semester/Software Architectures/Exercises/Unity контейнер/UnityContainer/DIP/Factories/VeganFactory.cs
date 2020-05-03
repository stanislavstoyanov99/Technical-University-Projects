namespace DIP.Factories
{
    using System.Collections.Generic;

    using DIP.Models;
    using DIP.Contracts;
    using DIP.ConcreteModels;

    public class VeganFactory : IMealFactory
    {
        public List<Dessert> CreateDessert()
        {
            var desserts = new List<Dessert>
            {
                new BasicLowCarbDessert(),
            };

            return desserts;
        }

        public Entree CreateEntree()
        {
            return new VeganEntree();
        }

        public MainCourse CreateMainCourse()
        {
            return new VeganMainCourse();
        }
    }
}
