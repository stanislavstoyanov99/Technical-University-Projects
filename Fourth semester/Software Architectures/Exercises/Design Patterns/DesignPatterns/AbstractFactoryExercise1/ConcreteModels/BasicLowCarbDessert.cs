using AbstractFactoryExercise1.Models;
namespace AbstractFactoryExercise1.ConcreteModels
{
    public class BasicLowCarbDessert : Dessert
    {
        public BasicLowCarbDessert()
        {
            Name = "Low carb dessert without animal products";
            Calories = 350;
            IsAlcoholic = false;
        }
    }
}
