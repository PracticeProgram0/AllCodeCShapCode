using Newtonsoft.Json;
using sundaram2_mvc.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Cache;
using System.Web;
using System.Web.Mvc;

namespace sundaram2_mvc.Controllers
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
                Name = "Btps",
                Age = 34,
                Phone = "123456",
                IsPass = "true"
            };

            var json=JsonConvert.SerializeObject(student);
            return Json(json,JsonRequestBehavior.AllowGet);
        }
    }
}