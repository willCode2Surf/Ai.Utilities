using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventLogger
{
    public class ConsoleLogger : ILogger
    {

        public void Log(Exception e)
        {
            Console.WriteLine(e.ToString());
        }
    }
}
