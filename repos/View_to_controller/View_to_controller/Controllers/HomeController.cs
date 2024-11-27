using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using View_to_controller.Models;

namespace View_to_controller.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string UserName,string UserPassword)
        {
           
            if (UserName == "Btps" && UserPassword == "12345")
            {
                return View();
            }
            return View("Index");

        }
        [HttpPost]
        public ActionResult LoginByFormCollection(FormCollection data)
        {
            string Username=data.Get("UserName");   
            string UserPassword=data.Get("UserPassword");

            if (Username == "Btps" && UserPassword == "12345")
            {
                return View();
            }
            return View("Index");
        }
        [HttpPost]
        public ActionResult LoginByModel(Student data)
        {      string username = data.UserName; 
            string password = data.PassWord;
            if(Username == "ram" && Password = "seeta")
            {
                return View();
            }
            
        }
    }
}