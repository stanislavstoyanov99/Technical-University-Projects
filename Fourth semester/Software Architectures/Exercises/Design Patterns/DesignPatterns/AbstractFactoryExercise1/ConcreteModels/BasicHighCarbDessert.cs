namespace AbstractFactoryExercise1.ConcreteModels
{
    using AbstractFactoryExercise1.Models;

    public class BasicHighCarbDessert : Dessert
    {
        public BasicHighCarbDessert()
        {
            Name = "High carb dessert without animal products";
            Calories = 400;
            IsAlcoholic = true;
        }
    }
}
