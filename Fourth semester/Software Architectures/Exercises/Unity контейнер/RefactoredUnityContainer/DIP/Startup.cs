namespace DIP
{
    using System;
    using System.Collections.Generic;

    using Unity;

    using DIP.Models;
    using DIP.Contracts;
    using DIP.Factories;

    public class Startup
    {
        public static void Main()
        {
            var container = new UnityContainer();
            var menuType = new string[] { "MeatLover", "VegitableLover", "NoMeatLover" };

            container.RegisterType<IMealFactory, MeatFactory>(menuType[0]);
            container.RegisterType<IMealFactory, VeganFactory>(menuType[1]);
            container.RegisterType<IMealFactory, VegetarianFactory>(menuType[2]);
            int menuChoice = new Random().Next() % 3;

            container.RegisterFactory<Entree>((c, t, n) => container.Resolve<IMealFactory>(menuType[menuChoice]).CreateEntree());
            container.RegisterFactory<MainCourse>((c, t, n) => container.Resolve<IMealFactory>(menuType[menuChoice]).CreateMainCourse());
            container.RegisterFactory<List<Dessert>>((c, t, n) => container.Resolve<IMealFactory>(menuType[menuChoice]).CreateDessert());
           
            var menu = container.Resolve<Menu>();

            #region Print Results
            Console.WriteLine($"Today menu of {menuType[menuChoice]} is :");
            Console.WriteLine(menu);
            Console.WriteLine($"Total calories: {menu.GetCalories()}");
             
            #endregion
        }
    }
}
