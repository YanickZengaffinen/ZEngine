using System;
using System.Collections.Generic;
using System.Text;
using ZEngine.Common.MarkerAttribute;

namespace ZEngine.Logging
{
    [Immutable]
    public class LogEventArgs : EventArgs
    {
        public Type Origin { get; }
        public string StackTrace { get; }
        public DateTime Time { get; }
        public string Message { get; }
        public LogLevel Level { get; }

        public LogEventArgs(Type origin, string stackTrace, DateTime time, string message, LogLevel level)
        {
            Origin = origin;
            StackTrace = stackTrace;
            Time = time;
            Message = message;
            Level = level;
        }

        public override string ToString()
        {
            return $"[{Time}][{Origin.FullName}][{Level}]: {Message} at {System.Environment.NewLine}{StackTrace}";
        }
    }
}
