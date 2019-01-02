using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Console.App.One.Test.MSTest
{
    [TestClass]
    public class MSTestConsoleAppOne
    {
        [TestMethod]
        public void PassingMSTest()
        {
            Assert.AreEqual(2, 2);
        }

        [TestMethod]
        public void FailingMSTest()
        {
            Assert.AreEqual(4, 4);
        }
    }
}
