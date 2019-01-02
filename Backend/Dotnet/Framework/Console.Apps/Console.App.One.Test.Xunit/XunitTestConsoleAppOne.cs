using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Console.App.One.Test.Xunit
{
    public class XunitTestConsoleAppOne
    {
        [Fact]
        public void PassingXunitTest()
        {
            Assert.Equal(4, Add(2, 2));
        }

        [Fact]
        public void FailingXunitTest()
        {
            Assert.Equal(5, Add(2, 3));
        }

        // Method to test against:
        public int Add(int x, int y)
        {
            return x + y;
        }
    }
}
