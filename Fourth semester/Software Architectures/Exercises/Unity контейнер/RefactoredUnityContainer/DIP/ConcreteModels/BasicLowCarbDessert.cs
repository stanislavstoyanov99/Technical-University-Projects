namespace DIP.ConcreteModels
{
    using DIP.Models;

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
