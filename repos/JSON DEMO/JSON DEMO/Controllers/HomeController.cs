using JSON_DEMO.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JSON_DEMO.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult JsonData()
        {
            Student student = new Student()
            {
                Name = "Btps Kanpur",
                Age = 20,
                Phone = "955577",
                IsPass = "true",
            };
            var json = JsonConvert.SerializeObject(student);
            return Json(json, JsonRequestBehavior.AllowGet);

        }
    }
}