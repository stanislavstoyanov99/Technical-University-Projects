namespace DIP.Contracts
{
    using System.Collections.Generic;

    using DIP.Models;

    public interface IMealFactory
    {
        Entree CreateEntree();

        MainCourse CreateMainCourse();

        List<Dessert> CreateDessert();
    }
}
