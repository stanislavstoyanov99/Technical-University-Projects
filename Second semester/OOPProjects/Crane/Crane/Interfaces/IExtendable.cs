using System;
using System.Collections.Generic;
using System.Text;

namespace Crane
{
    public interface IExtendable
    {
        void Extend(double step);
        void Shrink(double step);
    }
}
