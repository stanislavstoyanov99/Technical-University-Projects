namespace AbstractFactoryExercise1.ConcreteModels
{
    using AbstractFactoryExercise1.Models;

    public class VegaterianEntree : Entree
    {
        public VegaterianEntree()
        {
            Name = "Starter without meat";
            Calories = 100;
            IsColdPrepared = true;
        }
    }
}
