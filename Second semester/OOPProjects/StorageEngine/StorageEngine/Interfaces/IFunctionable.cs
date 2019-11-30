using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageEngine.Interfaces
{
    interface IFunctionable
    {
        void RotateClockwize(int voltage, int rpm);
        void RotateCounterClockwize(int voltage, int rpm);
        void CalculateKPD(double capacity, int voltage, int amperage);
    }
}
