using System;
using System.Windows.Forms;

namespace EnginesLibrary
{
    public class Generator : BaseЕngine, IProduceable
    {
        public Generator() : base()
        {

        }

        public Generator(int id, decimal priceRedCard, decimal priceGreenCard, double capacity,
            int voltage, int rpm, int amperage)
            : base(id, priceRedCard, priceGreenCard, capacity,
            voltage, rpm, amperage)
        {
            Id = id;
            PriceRedCard = priceRedCard;
            PriceGreenCard = priceGreenCard;
            Capacity = capacity;
            Voltage = voltage;
            Rpm = rpm;
            Amperage = amperage;
        }

        public void ProduceEnergy(int rpm)
        {
            if (rpm < Rpm)
            {
                MessageBox.Show("Подадените обороти са по-ниски от максимално допустимите и генераторът няма да произведе ток.");
            }
            else if (rpm > Rpm)
            {
                MessageBox.Show("Внимание! Подадените обороти са по-високи от максимално допустимите. Опасност от изгаряне.");
            }
            else
            {
                Random randomNumber = new Random();
                int producedVoltage = randomNumber.Next(12, 401); // from 12 to 400 voltage produced
                MessageBox.Show($"Генераторът успешно произведе {producedVoltage} V напрежение.");
            }
        }
    }
}
