using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc2.Controllers
{
    public class homeController : Controller
    {
        // GET: home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult about()
        {
            return View();
        }
        public ActionResult contact()
        {
            return View();
        }
    }
}