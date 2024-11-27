using mvcs2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcs2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Btps bt = new Btps
            {
                id = 1,
                name = "Ram",
                address = "UNNAO"
            };

            return View(bt);
        }
        public ActionResult About()
        {

            return View();
        }
    }
}