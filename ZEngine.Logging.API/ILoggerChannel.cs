using System;
using System.Collections.Generic;
using System.Text;
using ZEngine.Common.Manager;

namespace ZEngine.Logging
{
    public interface ILoggerChannel : IIdentifiable
    {
        /// <summary>
        /// The loglevel of this channel
        /// </summary>
        LogLevel LogLevel { get; }

        /// <summary>
        /// Whenever something is logged that concerns (according to the loglevel) this channel
        /// </summary>
        void Log( LogEventArgs logEvent );
    }
}
