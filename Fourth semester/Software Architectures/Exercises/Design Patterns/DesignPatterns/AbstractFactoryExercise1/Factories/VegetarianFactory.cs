﻿namespace AbstractFactoryExercise1.Factories
{
    using System.Collections.Generic;

    using AbstractFactoryExercise1.Models;
    using AbstractFactoryExercise1.Contracts;
    using AbstractFactoryExercise1.ConcreteModels;

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