using JQUERY_MVC.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JQUERY_MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public string  AjexCallGET()
        {
            return "Ajex Call GET ho rahi get  okey ";
        }
        [HttpPost]
        public string  AjaxCallPost(Login data)
        {
         string name = data.UserName;
           string pass= data.Password;

            return $"UserName ={name} Password is ={pass}";
        }


        public  ActionResult Jsonclass()
        {
            return View();  
        }

        public ActionResult JCLASS()
        {
            return View();  
        }

        public JsonResult JsonData()
        {
            Login Login = new Login()
            {
                UserName = "Btps",
                Password = "ram@123"

            };
            var json = JsonConvert.SerializeObject(Login);
            return Json(json, JsonRequestBehavior.AllowGet);

        }
    }
}