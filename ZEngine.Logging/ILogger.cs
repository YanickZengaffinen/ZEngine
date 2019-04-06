using System;
using System.Collections.Generic;
using System.Text;

namespace ZEngine.Logging
{
    public interface ILogger
    {
        void Debug(string message);

        void Info(string message);

        void Warn(string message);

        void Error(string message);
    }
}
