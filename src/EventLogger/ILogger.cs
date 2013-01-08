using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventLogger
{
    public interface ILogger
    {
        void Log(Exception e);
    }
}
