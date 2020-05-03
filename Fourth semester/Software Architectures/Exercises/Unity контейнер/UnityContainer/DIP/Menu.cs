namespace DIP
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;

    using DIP.Models;
    using DIP.Contracts;

    public class Menu : IMenu
    {
        private IMealFactory mealFactory;

        public Menu(IMealFactory mealFactory)
        {
            this.mealFactory = mealFactory;
            this.EntreeItem = this.mealFactory.CreateEntree();
            this.MainCourseItem = this.mealFactory.CreateMainCourse();
            this.DessertItems = this.mealFactory.CreateDessert();
        }

        public Entree EntreeItem { get; private set; }

        public MainCourse MainCourseItem { get; private set; }

        public List<Dessert> DessertItems { get; private set; }

        public int GetCalories()
        {
            var calories = this.EntreeItem.Calories + MainCourseItem.Calories + DessertItems.Sum(x => x.Calories);

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
