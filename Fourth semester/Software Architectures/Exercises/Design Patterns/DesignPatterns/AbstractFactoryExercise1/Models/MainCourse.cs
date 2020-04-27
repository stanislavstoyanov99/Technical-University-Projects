namespace AbstractFactoryExercise1.Models
{
    public abstract class MainCourse : Meal
    {
        protected bool IsLowCarb { get; set; }
    }
}
