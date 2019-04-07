using System;
using System.Linq;
using System.Text;

namespace Logging.Util
{
    public static class StackTraceUtil
    {

        private static string stackTraceStart = "  at ";

        /// <summary>
        /// Get the stacktrace from root to the most accurate line of the type
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static string GetStackTraceTo(Type type)
        {
            string start = stackTraceStart + type.FullName;
            var lines = Environment.StackTrace.Split('\n', '\r').ToList();

            StringBuilder returnValue = new StringBuilder();

            bool append = false;
            foreach (string line in lines)
            {
                if (!append && line.StartsWith(start))
                {
                    append = true;
                }

                if (append)
                {
                    returnValue.AppendLine(line);
                }
            }

            return returnValue.ToString();
        }

    }
}
