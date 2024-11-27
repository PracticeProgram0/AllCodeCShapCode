using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Cache;
using System.Web;
using System.Web.Mvc;
using mvc22.Models;

namespace mvc22.Controllers
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
            Student student = new Student
            {
                Name = "satyam",
                Age = 22,
                Phone = "1234567",
                IsPass = true,

            };
            return View(student);
        }
    }
}