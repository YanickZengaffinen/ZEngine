using System;
using System.Collections.Generic;
using System.Text;
using ZEngine.Logging.Manager;

namespace ZEngine.Logging.Impl.Manager
{
    /// <summary>
    /// Synchronous implementation of the <see cref="ILoggerChannelManager"/>
    /// </summary>
    public class LoggerChannelManager
    {
        private List<ILoggerChannel> channels = new List<ILoggerChannel>();

        public void Register(ILoggerChannel channel)
        {
            channels.Add(channel);
        }

        public void Log(LogEventArgs log)
        {
            foreach(ILoggerChannel channel in channels)
            {
                if(channel.LogLevel >= log.Level)
                {
                    channel.Log(log);
                }
            }
        }

    }
}
