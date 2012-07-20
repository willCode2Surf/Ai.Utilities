using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI.Defensive
{
    public class ObjectNotNullGuard : IGuard<object>
    {
        public bool Protect(object objToCheck)
        {
            return !(objToCheck == null);
                
        }
    }
}
