using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using layoutpage.Models;

namespace layoutpage.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Contact()
        {
            Student std = new Student()
            {
                UserName ="Manish",
                UserPassword = "1234"
            };

            return View(std);

        }
        public ActionResult Help()
        {
            return View();
        }
    }
}