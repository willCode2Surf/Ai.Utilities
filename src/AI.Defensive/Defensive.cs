using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI.Defensive
{
    public static class Defensive
    {
        private static Guard _guard = new Guard();

        public static Guard Guard
        {

            get { return _guard; }

        }
    }
}
