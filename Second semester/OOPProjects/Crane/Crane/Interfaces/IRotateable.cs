using System;
using System.Collections.Generic;
using System.Text;

namespace Crane
{
    public interface IRotateable
    {
        void RotateClockwize(double step);
        void RotateCounterClockWize(double step);
    }
}
