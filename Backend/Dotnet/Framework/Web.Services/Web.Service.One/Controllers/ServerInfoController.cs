using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.ComponentModel.DataAnnotations;
using System.Web;
using Web.Service.CommonLib;

namespace Web.Service.One.Controllers
{
    public class ServerInfoController : ApiController
    {
        [Route("api/ServerInfo/GetServerName")]
        [HttpGet]
        public IHttpActionResult GetServerName()
        {
            string serverName = HostnameAndServerTime.GetHostname();
            return Json($"Server IP: {serverName}");
        }

        [Route("api/ServerInfo/GetServerTime")]
        [HttpGet]
        public IHttpActionResult GetServerTime()
        {
            string serverTime = HostnameAndServerTime.GetServerTime();
            return Json($"Server Time: {serverTime}");
        }
    }
}
