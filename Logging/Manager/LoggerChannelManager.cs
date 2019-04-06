using System.Collections.Generic;

namespace Logging.Impl.Manager
{
    /// <summary>
    /// Synchronous implementation of the <see cref="ILoggerChannelManager"/>
    /// </summary>
    public class LoggerChannelManager
    {
        private static List<ILoggerChannel> channels = new List<ILoggerChannel>();

        /// <summary>
        /// Register a channel that the manager will output to
        /// </summary>
        /// <param name="channel"></param>
        public static void Register(ILoggerChannel channel)
        {
            channels.Add(channel);
        }

        /// <summary>
        /// Forward a message to all channels that are listening
        /// </summary>
        /// <param name="log"></param>
        public static void Log(LogEventArgs log)
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
