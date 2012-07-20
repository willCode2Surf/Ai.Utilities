using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AI.Defensive.Guard.Tests
{
    [TestClass]
    public class General
    {
        [TestMethod]
        public void FluentWorx()
        {
            string str = "stuff";
            object objInt = "32";
            object objDec = "32.2";
            object objNotNull = new Object();

            Defensive.Guard.IsNotNullOrEmptyString(str,"str")
                .IsOfType<int>(objInt,"objInt")
                .IsNotNull(objNotNull,"objNotNull");
            
        }
    }
}
