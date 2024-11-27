using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Router.Controllers
{
    [RoutePrefix("btps")]
    public class Home2Controller : Controller
    {


        [Route("~/")]
        public ActionResult Index()
        {
            return View();
        }

        [Route("memo")]
        public ActionResult About()
        {
            return View();
        }
    }
}