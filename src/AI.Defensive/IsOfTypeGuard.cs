using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI.Defensive
{
    public class IsOfTypeGuard<U> : IGuard<object>
    {
        public bool Protect(object objToCheck)
        {
            return this.ProtectInternal(objToCheck);

        }

        private bool ProtectInternal(object objToCheck)
        {
            return !(Convert.ChangeType(objToCheck, typeof(U)) == null);
                
        }
    }
}
