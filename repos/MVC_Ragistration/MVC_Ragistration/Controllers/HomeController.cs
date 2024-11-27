using MVC_Ragistration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Ragistration.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Employee EMP = new Employee()
            {
                id = 1,
                name = "Manish",
                phon = "1234567890",
                Address = "unnao"
            };

            return View(EMP);
        }
    }
}