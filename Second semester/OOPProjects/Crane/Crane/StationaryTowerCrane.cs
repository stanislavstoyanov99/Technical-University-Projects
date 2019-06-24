using System;
using System.Collections.Generic;
using System.Text;

namespace Crane
{
    public class StationaryTowerCrane: Crane, IRotateable
    {
        public double CurrentRotatePosition { get; private set; }

        public StationaryTowerCrane(double maxMassToLift, double maxHeightToLift): base(maxMassToLift, maxHeightToLift)
        {
            CurrentRotatePosition = 0;
        }

        public void RotateClockwize(double step)
        {
            if (CurrentRotatePosition + step > 360)
            {
                throw new Exception("You cannot rotate more than 360 degrees.");
            }

            CurrentRotatePosition += step;
        }

        public void RotateCounterClockWize(double step)
        {
            if (CurrentRotatePosition - step < 0)
            {
                throw new Exception("The rotation degree cannot be below zero.");
            }

            CurrentRotatePosition -= step;
        }
    }
}
