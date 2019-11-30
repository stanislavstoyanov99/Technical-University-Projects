using System.Windows.Forms;

namespace EnginesLibrary
{
    public class BaseЕngine
    {
        public int Id { get; set; }

        public decimal PriceRedCard { get; set; }

        public decimal PriceGreenCard { get; set; }

        public double Capacity { get; set; }

        public int Voltage { get; set; }

        public int Rpm { get; set; }

        public int Amperage { get; set; }

        public int Frequency { get; set; }

        public BaseЕngine()
        {

        }

        public BaseЕngine(int id, decimal priceRedCard, decimal priceGreenCard, double capacity,
            int voltage, int rpm, int amperage)
        {
            Id = id;
            PriceRedCard = priceRedCard;
            PriceGreenCard = priceGreenCard;
            Capacity = capacity;
            Voltage = voltage;
            Rpm = rpm;
            Amperage = amperage;
        }

        public void CalculateKPD(double capacity, int voltage, int amperage)
        {
            double cosPhi = capacity / (1.732 * voltage * amperage);
            double kpdAmount = capacity / (1.732 * voltage * amperage * cosPhi);
            MessageBox.Show($"КПД на избраният двигател е: {kpdAmount:F3}");
        }
    }
}
