using System;
using System.Collections.Generic;
using System.Text;

namespace Crane
{
    public class TruckCrane: Crane, IRotateable, IExtendable
    {
        public double CurrentRotatePosition { get; private set; }
        public double CurrentExtendedPosition { get; private set; }
        public double CurrentShrinkedPosition { get; private set; }
        public double MaxExtendedPosition { get; private set; }

        public TruckCrane(double maxMassToLift, double maxHeightToLift): base(maxMassToLift, maxHeightToLift)
        {
            CurrentRotatePosition = 0;
            CurrentExtendedPosition = 0;
            CurrentShrinkedPosition = 0;
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

        public void Shrink(double step)
        {
            if (CurrentShrinkedPosition - step < 0)
            {
                throw new Exception("You cannot shrink position because it is a negative number");
            }

            CurrentShrinkedPosition -= step;
        }

        public void Extend(double step)
        {
            if (CurrentExtendedPosition + step > MaxExtendedPosition)
            {
                throw new Exception("You cannot extend more than the maximum allowed position.");
            }

            CurrentExtendedPosition += step;
        }
    }
}
