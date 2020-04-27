namespace AbstractFactoryExercise1.Contracts
{
    using System.Collections.Generic;

    using AbstractFactoryExercise1.Models;

    public interface IMealFactory
    {
        Entree CreateEntree();

        MainCourse CreateMainCourse();

        List<Dessert> CreateDessert();
    }
}
