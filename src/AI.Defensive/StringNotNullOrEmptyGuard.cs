using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI.Defensive
{
    public class StringNotNullOrEmptyGuard : IGuard<string>
    {
        public bool Protect(string objToCheck)
        {
            return !String.IsNullOrEmpty(objToCheck);
                
        }

        
    }
}
