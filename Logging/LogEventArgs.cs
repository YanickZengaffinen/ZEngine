﻿using System;

namespace Logging
{
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
            return $"[{Time}][{Origin.FullName}][{Level}]: {Message}{System.Environment.NewLine}{StackTrace}";
        }

        /// <summary>
        /// ToString but without stacktrace
        /// </summary>
        /// <returns></returns>
        public string ToStringMinimal()
        {
            return $"[{Time}][{Origin.FullName}][{Level}]: {Message}";
        }
    }
}
