using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Web.Http;

namespace webapi.Controllers

{
    public class GetDataController : ApiController
    {
        [HttpGet]
       public string[]GetData()
        {
            string[] data = { "java", "c#" ,"php"};

            return data;
        }
        [HttpGet]
        public string GetDatabyid(int id)
        {
            string[] data = { "java", "c#", "php" };

            return data[id];
        }
    }
}
