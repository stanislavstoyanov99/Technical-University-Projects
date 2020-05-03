namespace DIP
{
    using System;
    using System.Collections.Generic;

    using Unity;
    using Unity.Resolution;

    using DIP.Contracts;
    using DIP.Factories;

    public class Startup
    {
        public static void Main()
        {
            var container = new UnityContainer();
            var menusList = new string[] { "Meat", "Vegan", "Vegetarian" };

            container.RegisterType<IMealFactory, MeatFactory>(menusList[0]);
            container.RegisterType<IMealFactory, VeganFactory>(menusList[1]);
            container.RegisterType<IMealFactory, VegetarianFactory>(menusList[2]);

            var menus = new Dictionary<string, IMenu>();

            foreach (var menuName in menusList)
            {
                var menu = container
                    .Resolve<Menu>(new ParameterOverride(typeof(IMealFactory), container.Resolve<IMealFactory>(menuName)));
                menus[menuName] = menu;
            }

            #region Print Results
            foreach (var menu in menus)
            {
                Console.WriteLine($"{menu.Key} Menu:");
                Console.WriteLine(menu.Value);
                Console.WriteLine($"Total calories: {menu.Value.GetCalories()}");
                Console.WriteLine();
            }
            #endregion
        }
    }
}
