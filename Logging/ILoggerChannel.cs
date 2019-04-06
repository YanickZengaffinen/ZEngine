namespace Logging
{
    public interface ILoggerChannel
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
