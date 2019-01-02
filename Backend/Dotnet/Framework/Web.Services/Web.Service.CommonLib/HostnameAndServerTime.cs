using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;

namespace Web.Service.CommonLib
{
    public static class HostnameAndServerTime
    {
        public static string GetHostname()
        {
            var serverName = Dns.GetHostName();
            return serverName.ToString();
        }
        public static string GetServerTime()
        {
            var serverTime = DateTime.Now;
            return serverTime.ToString();
        }
    }
}
