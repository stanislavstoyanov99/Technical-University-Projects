namespace AbstractFactoryExercise1.ConcreteModels
{
    using AbstractFactoryExercise1.Models;

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
