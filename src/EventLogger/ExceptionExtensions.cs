using EventLogger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{
    public static class ExceptionExtensions
    {
        public static void Log(this Exception exception)
        {
            ILogger logger = new ConsoleLogger();
            logger.Log(exception);
        }
    }
}
