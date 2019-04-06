using Logging.Impl.Manager;
using Logging.Util;
using System;

namespace Logging
{
    public class Logger
    {
        /// <summary>
        /// Create a logger for a specific type
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static Logger Of(Type type)
        {
            return new Logger(type);
        }

        private Type type;

        private Logger(Type type)
        {
            this.type = type;
        }

        /// <summary>
        /// Log a message
        /// </summary>
        /// <param name="message"></param>
        /// <param name="logLevel"></param>
        public void Log(string message, LogLevel logLevel)
        {
            LoggerChannelManager.Log(new LogEventArgs(type, StackTraceUtil.GetStackTraceTo(type), DateTime.Now, message, logLevel));
        }
        
        public void Debug(string message) => Log(message, LogLevel.Debug);
        public void Info(string message) => Log(message, LogLevel.Info);
        public void Warn(string message) => Log(message, LogLevel.Warn);
        public void Error(string message) => Log(message, LogLevel.Error);

    }
}
