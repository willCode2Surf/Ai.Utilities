using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI.Defensive
{
    public class Guard
    {

        protected void Check<TRule, TInput>(TInput input, string argName)
            where TRule : new()
        {
            dynamic rule = new TRule();
            if(!rule.Protect(input))
                throw new InvalidOperationException(String.Format("argument *{0}* failed rule {1}",typeof(TInput).Name,argName));
        }

        public Guard IsNotNullOrEmptyString(string strToCheck,string argName)
        {
            Check<StringNotNullOrEmptyGuard,string>(strToCheck, argName);
            return this;
        }

        public Guard IsOfType<T>(object objToCheck,string argName)
        {
            Check<IsOfTypeGuard<T>, object>(objToCheck, argName);
            return this;
        }

        public Guard IsNotNull(object obj, string argName)
        {
            Check<ObjectNotNullGuard, object>(obj, argName);
            return this;
        }
    }
}
