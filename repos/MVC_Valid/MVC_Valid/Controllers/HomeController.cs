using MVC_Valid.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Valid.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Registration()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Registrationp(valid data)
        {
            if (ModelState.IsValid)
            {
                return View();

            }
            return View("Registration");

        }
    }
}