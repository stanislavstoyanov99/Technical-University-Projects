using System;
using System.Collections.Generic;
using System.Text;

namespace Crane
{
    interface ILiftable
    {
        void LiftUp(double step);
        void LowerDown(double step);
    }
}
