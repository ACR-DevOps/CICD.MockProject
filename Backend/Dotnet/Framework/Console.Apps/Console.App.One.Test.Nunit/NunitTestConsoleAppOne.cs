using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Console.App.One.Test.Nunit
{
    [TestFixture]
    public class NunitTestConsoleAppOne
    {
        [Test]
        public void PassingNunitTest()
        {
            Assert.That(Multiply(2, 3), Is.EqualTo(6));
        }

        [Test]
        public void FailingNunitTest()
        {
            Assert.That(Multiply(2, 4), Is.EqualTo(8));
        }

        // Method to test against:
        public int Multiply(int x, int y)
        {
            return x * y;
        }
    }
}
