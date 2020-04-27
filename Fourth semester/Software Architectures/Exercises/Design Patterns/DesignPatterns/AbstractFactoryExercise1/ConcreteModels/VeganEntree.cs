namespace AbstractFactoryExercise1.ConcreteModels
{
    using AbstractFactoryExercise1.Models;

    public class VeganEntree : Entree
    {
        public VeganEntree()
        {
            Name = "Starter without animal products";
            Calories = 50;
            IsColdPrepared = true;
        }
    }
}
