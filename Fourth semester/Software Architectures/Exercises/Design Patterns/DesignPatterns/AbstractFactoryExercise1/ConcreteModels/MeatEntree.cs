namespace AbstractFactoryExercise1.ConcreteModels
{
    using AbstractFactoryExercise1.Models;

    public class MeatEntree : Entree
    {
        public MeatEntree()
        {
            Name = "Starter with meat";
            Calories = 200;
            IsColdPrepared = false;
        }
    }
}
