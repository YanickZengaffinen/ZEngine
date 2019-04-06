using System;
using System.Collections.Generic;
using System.Text;
using ZEngine.Common.API.MarkerAttribute;

namespace ZEngine.Logging
{
    [Immutable]
    public class LogEventArgs : EventArgs
    {
        public DateTime Time { get; }
        public string Message { get; }
        public LogLevel Level { get; }

        public LogEventArgs(string message, LogLevel level)
        {
            Message = message;
            Level = level;
        }
    }
}
