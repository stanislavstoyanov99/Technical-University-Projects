using System;
using System.Collections.Generic;
using System.Text;

namespace Crane
{
    public abstract class Crane: ILiftable
    {
        public double MaxMassToLift { get; private set; }
        public double MaxHeightToLift { get; private set; }
        public double CurrentHeight { get; private set; }

        public Crane(double maxMassToLift, double maxHeightToLift)
        {
            MaxMassToLift = maxMassToLift;
            MaxHeightToLift = maxHeightToLift;
        }

        public void LiftUp(double step)
        {
            if (CurrentHeight + step > MaxHeightToLift)
            {
                throw new Exception("The current height is bigger than the max height of lifting.");
            }

            CurrentHeight += step;
        }

        public void LowerDown(double step)
        {
            if (CurrentHeight - step < 0)
            {
                throw new Exception("The current height cannot be negative.");
            }

            CurrentHeight -= step;
        }
    }
}
