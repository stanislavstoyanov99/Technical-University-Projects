namespace AbstractFactoryExercise1.ConcreteModels
{
    using AbstractFactoryExercise1.Models;

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
