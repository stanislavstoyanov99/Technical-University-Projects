namespace DIP.ConcreteModels
{
    using DIP.Models;

    public class VeganMainCourse : MainCourse
    {
        public VeganMainCourse()
        {
            Name = "Main dish without animal products";
            Calories = 350;
            IsLowCarb = true;
        }
    }
}
