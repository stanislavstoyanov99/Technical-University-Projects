namespace DIP.Factories
{
    using System.Collections.Generic;

    using DIP.Models;
    using DIP.Contracts;
    using DIP.ConcreteModels;

    public class VegetarianFactory : IMealFactory
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
            return new VegaterianEntree();
        }

        public MainCourse CreateMainCourse()
        {
            return new VegetarianMainCourse();
        }
    }
}
