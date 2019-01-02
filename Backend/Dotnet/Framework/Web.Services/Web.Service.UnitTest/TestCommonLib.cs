using System;
using Xunit;
using Web.Service.CommonLib;

namespace Web.Service.UnitTest
{
    public class TestCommonLib
    {
        [Fact]
        public void ShouldHostnameReturnDeployedServername()
        {
            string actualResult = HostnameAndServerTime.GetHostname();
            string expectedResult = "CUV-CICDINT";
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void ShouldServertimeReturnDeployedServertime()
        {
            string actualResult = HostnameAndServerTime.GetServerTime();
            string expectedResult = "wrong server time";
            Assert.NotEqual(expectedResult, actualResult);
        }
    }
}
