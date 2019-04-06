using System;
using System.Collections.Generic;
using System.Text;

namespace ZEngine.Logging
{
    public class Logger
    {

        public void Log(string message, LogLevel logLevel)
        {

        }

        public void Info(string message)
        {
        }

        public static Logger For(object obj)
        {
            obj.GetType();
        }
        
    }
}
