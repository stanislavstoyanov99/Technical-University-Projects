namespace DIP.ConcreteModels
{
    using DIP.Models;

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
