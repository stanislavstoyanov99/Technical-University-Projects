using System;
using System.Collections.Generic;
using System.Text;

namespace Crane
{
    public interface IMoveable
    {
        void MoveLeft(double step);
        void MoveRight(double step);
    }
}
