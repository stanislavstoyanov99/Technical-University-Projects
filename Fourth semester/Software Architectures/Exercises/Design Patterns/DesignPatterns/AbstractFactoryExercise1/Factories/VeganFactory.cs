namespace AbstractFactoryExercise1.Factories
{
    using System.Collections.Generic;

    using AbstractFactoryExercise1.Models;
    using AbstractFactoryExercise1.Contracts;
    using AbstractFactoryExercise1.ConcreteModels;

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
