using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI.Defensive
{
    public interface IGuard<T>
    {
        bool Protect(T objToCheck);
    }
}
