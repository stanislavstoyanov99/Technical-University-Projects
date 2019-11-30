using System;
using System.Collections.Generic;

namespace StorageEngine
{
    [Serializable]
    public class Engine
    {
        // Properties
        public int Id { get; set; }

        public decimal PriceRedCard { get; set; }

        public decimal PriceGreenCard { get; set; }

        public double Capacity { get; set; }

        public int Voltage { get; set; }

        public int Rpm { get; set; }

        public int Amperage { get; set; }

        public int Frequency { get; set; } = 50; // European Standard, American Standard - 60Hz

        // Default Constructor
        public Engine()
        {

        }

        // Overload Constructors
        public Engine(int id, decimal priceRedCard, decimal priceGreenCard, double capacity,
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
    }
}
