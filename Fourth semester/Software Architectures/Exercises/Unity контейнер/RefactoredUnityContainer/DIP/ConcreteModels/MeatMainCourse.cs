namespace DIP.ConcreteModels
{
    using DIP.Models;

    public class MeatMainCourse : MainCourse
    {
        public MeatMainCourse()
        {
            Name = "Main dish with meat";
            Calories = 550;
            IsLowCarb = true;
        }
    }
}
