using Newtonsoft.Json;
using sundaram_mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sundaram_mvc.Controllers
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
                Age =  34,
                Phone = "123456789",
                IsPass = "true"
            };
            var json= JsonConvert.SerializeObject(student);
            return Json(json, JsonRequestBehavior.AllowGet);
        }
    }
}