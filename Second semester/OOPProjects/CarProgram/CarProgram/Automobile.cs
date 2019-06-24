using System;

namespace CarProgram
{
    class Automobile
    {
        private int maxSpeed, engineCapacity, currentSpeed;
        private bool isTheEngineWorks;
        private string brand, model;

        public Automobile(int maxSpeed, int EngineCapacity, string Brand, string Model)
        {
            maxSpeed = MaxSpeed;
            engineCapacity = EngineCapacity;
            brand = Brand;
            model = Model;
        }

        public bool StartEngine()
        {
            currentSpeed = 0;
            isTheEngineWorks = true;

            return isTheEngineWorks;
        }

        public bool Accelerate()
        {
            bool isTheEngineAccelerate = false;

            if (isTheEngineWorks && currentSpeed <= maxSpeed)
            {
                currentSpeed += 5;
                isTheEngineAccelerate = true;
            }

            return isTheEngineAccelerate;
        }

        public bool Brake()
        {
            bool isTheEngineBrake = false;
            if (isTheEngineWorks && currentSpeed <= maxSpeed && currentSpeed >= 40)
            {
                currentSpeed -= 40;
                isTheEngineBrake = true;
            }

            return isTheEngineBrake;
        }

        public bool StopEngine()
        {
            if (currentSpeed == 0 && isTheEngineWorks)
            {
                isTheEngineWorks = false;
            }

            return isTheEngineWorks;
        }

        public int CapacityInKw
        {
            get { return (int)(engineCapacity * 0.7); }
        }
        public int MaxSpeed
        {
            get { return maxSpeed; }
        }

        public int EngineCapacity
        {
            get { return engineCapacity; }
        }

        public int CurrentSpeed
        {
            get { return currentSpeed; }
        }

        public bool IsTheEngineWorks
        {
            get { return isTheEngineWorks; }
        }

        public string Brand
        {
            get { return brand; }
        }

        public string Model
        {
            get { return model; }
        }
    }
}
