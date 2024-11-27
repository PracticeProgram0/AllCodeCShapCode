using Employee_mvc.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Employee_mvc.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Registration()
        {
            return View();
        }


        [HttpPost]
        public ActionResult RegistrationByModel(Registration data)
        {

           
            Registration rag = new Registration()
            {
                Firstname = data.Firstname,
                Lastname = data.Lastname,
                Email = data.Email,
                Phone = data.Phone,
                Address = data.Address,
                City = data.City,
                State = data.State,
                Zip = data.Zip,
                Password = data.Password,
                ConfirmPassword = data.ConfirmPassword
            };
            return View(rag);
        }
        [HttpPost]
        public ActionResult LoginByModel(Login data)
        {
            string username = data.Username;
            string password = data.Password;

            String select = "";


            if (username == "ram" && password == "seeta")
            {
                return View();
            }
            return RedirectToAction("Index");
        }
    }
}