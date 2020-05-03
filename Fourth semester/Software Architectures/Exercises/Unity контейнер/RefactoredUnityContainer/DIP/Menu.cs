namespace DIP
{
    using System.Text;
    using System.Collections.Generic;

    using DIP.Models;
    using DIP.Contracts;
    using System.Linq;

    public class Menu : IMenu
    {
        public Menu(Entree entree, MainCourse mainCourse, List<Dessert> dessert)
        {
            this.EntreeItem = entree;
            this.MainCourseItem = mainCourse;
            this.DessertItems = dessert;
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
