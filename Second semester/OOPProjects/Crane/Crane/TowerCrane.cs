using System;
using System.Collections.Generic;
using System.Text;

namespace Crane
{
    public class TowerCrane: StationaryTowerCrane, IMoveable
    {
        public double CurrentPosition { get; private set; }
        public double MaxPositionToMove { get; private set; }
        public double MinPositionToMove { get; private set; }

        public TowerCrane(double maxPositionToMove, double minPositionToMove, double maxMassToLift, double maxHeightToLift)
            : base(maxMassToLift, maxHeightToLift)
        {
            CurrentPosition = 0;
            MaxPositionToMove = maxPositionToMove;
            MinPositionToMove = minPositionToMove;
        }
        public void MoveLeft(double step)
        {

        }

        public void MoveRight(double step)
        {
            if (CurrentPosition + step > MaxPositionToMove)
            {
                throw new Exception("The current position is over the max position allowed");
            }
            CurrentPosition += step;
        }
    }
}
