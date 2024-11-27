using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Api.Controllers
{
    public class HomeController : ApiController
    {
        [HttpGet]
        public string[]raj()
        {
            string[] raj = { "java", "js" };

            return raj;
        }
        [HttpGet]
        public string Raju(int id)
        {
          string[] ram={ "rahul","ram" };

            return ram[id];
        }
    }
}
