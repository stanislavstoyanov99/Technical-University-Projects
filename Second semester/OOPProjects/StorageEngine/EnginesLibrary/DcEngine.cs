using System;
using System.Windows.Forms;

namespace EnginesLibrary
{
    public class DcEngine : BaseЕngine, IFunctionable
    {
        public DcEngine() : base()
        {

        }

        public DcEngine(int id, decimal priceRedCard, decimal priceGreenCard, double capacity,
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

        public void RotateClockwize(int voltage, int rpm)
        {
            if (voltage < Voltage)
            {
                MessageBox.Show("Подаденото напрежение е по-ниско от максимално допустимото и двигателят няма да се завърти.");
            }
            else if (voltage > Voltage)
            {
                MessageBox.Show("Внимание! Напрежението е по-високо от максимално допустимото. Опасност от изгаряне.");
            }
            else
            {
                Random randomNumber = new Random();
                int changedRpm = randomNumber.Next(2000, rpm + 1); // from 2000 to maximum allowed rpm
                MessageBox.Show($"Успешно завъртане на двигателя и достигане на {changedRpm} оборота.");
            }
        }

        public void RotateCounterClockwize(int voltage, int rpm)
        {
            if (voltage < Voltage)
            {
                MessageBox.Show("Подаденото напрежение е по-ниско от максимално допустимото и двигателят няма да се завърти.");
            }
            else if (voltage > Voltage)
            {
                MessageBox.Show("Внимание! Напрежението е по-високо от максимално допустимото. Опасност от изгаряне.");
            }
            else
            {
                string[] polarityArray = new string[] { "+", "-" };
                new Random().Shuffle(polarityArray);

                if (polarityArray[0] == "+" && polarityArray[1] == "-")
                {
                    MessageBox.Show("Поляритетът не е променен и няма да настъпи завъртане на двигателя в обратна посока.");
                    return;
                }

                MessageBox.Show(string.Join(" ", polarityArray), "Поляритет");
                MessageBox.Show($"Успешно завъртане обратно на часовниковата стрелка и достигане на максималните {rpm} оборота.");
            }
        }
    }
}
