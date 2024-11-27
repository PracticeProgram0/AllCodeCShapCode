using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcs1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Username = "Btps is Education Center";
            ViewData["Password"] = "123456789";
            var userstatus = 1;
            if(userstatus==1)
            {
                ViewBag.user = "ok";
            }
            else
            {
                ViewBag.user = "not ok";
            }
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
    }
}