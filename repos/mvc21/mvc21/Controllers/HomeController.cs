using mvc21.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Web;
using System.Web.Mvc;


namespace mvc21.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            student st = new student()
            {
                id = 1,
                name = "Ram",
                address = "Unnao"
            };

            return View(st);
        }
    }
}