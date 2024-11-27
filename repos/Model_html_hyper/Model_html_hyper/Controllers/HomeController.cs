using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model_html_hyper.Models;

namespace Model_html_hyper.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Student student =
                    new Student
                    {
                        id = 1,
                        Name = "MANISH",
                        Age = 20,
                        phone="3098109"

                    };
            return View(student);
        }
       
       
    }
}