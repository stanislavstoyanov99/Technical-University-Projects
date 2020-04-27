namespace AbstractFactoryExercise1
{
    using System;

    using AbstractFactoryExercise1.Factories;

    public class Startup
    {
        public static void Main()
        {
            var meatFactory = new MeatFactory();
            var meatMenu = new Menu(meatFactory);

            var vegetarianFactory = new VegetarianFactory();
            var vegetarianMenu = new Menu(vegetarianFactory);

            var veganFactory = new VeganFactory();
            var veganMenu = new Menu(veganFactory);

            Console.WriteLine("Meat Menu:");
            Console.WriteLine(meatMenu);
            Console.WriteLine($"Total calories: {meatMenu.GetCalories()}");
            Console.WriteLine();

            Console.WriteLine("Vegetarian Menu:");
            Console.WriteLine(vegetarianMenu);
            Console.WriteLine($"Total calories: {vegetarianMenu.GetCalories()}");
            Console.WriteLine();

            Console.WriteLine("Vegan Menu:");
            Console.WriteLine(veganMenu);
            Console.WriteLine($"Total calories: {meatMenu.GetCalories()}");
        }
    }
}
