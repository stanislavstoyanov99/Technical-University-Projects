namespace DIP.ConcreteModels
{
    using DIP.Models;

    public class VegetarianMainCourse : MainCourse
    {
        public VegetarianMainCourse()
        {
            Name = "Main dish without meat";
            Calories = 450;
            IsLowCarb = false;
        }
    }
}
