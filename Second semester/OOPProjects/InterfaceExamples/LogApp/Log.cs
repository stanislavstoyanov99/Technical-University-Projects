using System;
using System.Collections.Generic;
using System.Text;

namespace LogApp
{
    public interface ILog
    {
        void Info(string information);
        void Warn(string warning);
        void Error(string error);
        void Error(string error, Exception ex);
    }
}

namespace LogApp.Loggers
{
    class DebugStringLong: ILog
    {
        public void Error
    }
}
