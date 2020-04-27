namespace AbstractFactoryExercise1
{
    using AbstractFactoryExercise1.Contracts;
    using AbstractFactoryExercise1.Models;

    using System.Text;
    using System.Collections.Generic;

    public class Menu : IMenu
    {
        public Entree EntreeItem { get; private set; }

        public MainCourse MainCourseItem { get; private set; }

        public List<Dessert> DessertItems { get; private set; }

        public Menu(IMealFactory factory)
        {
            this.EntreeItem = factory.CreateEntree();
            this.MainCourseItem = factory.CreateMainCourse();
            this.DessertItems = factory.CreateDessert();
        }

        public int GetCalories()
        {
            var calories = this.EntreeItem.Calories + MainCourseItem.Calories;

            foreach (var dessert in this.DessertItems)
            {
                calories += dessert.Calories;
            }

            return calories;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"The menu consists of:");
            sb.AppendLine($"Starter: {EntreeItem.Name}");
            sb.AppendLine($"Main dish: {MainCourseItem.Name}");
            sb.AppendLine($"Desserts:");

            foreach (var dessert in this.DessertItems)
            {
                sb.AppendLine($"-- {dessert.Name}");
            }

            return sb.ToString();
        }
    }
}
