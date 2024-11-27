using Login_FromAuthentication_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Login_FromAuthentication_MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Login data)
        {
            if (!ModelState.IsValid || data == null) 
            {
                return View(data);
            }
            Database db = new Database();

            var user = db.LoginData(data);
            if (user != null) 
            {
                //var password=data.Password;
                //if (username.ToUpper() == "BTPS" || password=="1234")
                //{
                FormsAuthentication.SetAuthCookie(user.Email, false);
                return RedirectToAction("Index", "User");

            }
            else
            {
                return View(data);
            }
            
        }

        public ActionResult Registration()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(Registration data)
        {
            Database database = new Database();
            if (data != null)
            {
                int result = database.DataInsert(data);
                ViewBag.info = "Data Insertedd Successfully ";
                if (result > 0)
                {
                    return RedirectToAction("index");
                }
            }
            return View();
        }


        //public ActionResult GetData(string email,string password)
        //{
        //    Database database = new Database();
        //    var data = database.SelectData(email,password);
        //    return View(data);
        //}
        //public ActionResult UpdateData(int id)
        //{
        //    Database database = new Database();
        //    var data = database.SelectData(id);

        //    return View(data);
        //}
        //[HttpPost]
        //public ActionResult UpdateData(MVCBatch newUpdateData)
        //{
        //    Database database = new Database();
        //    var result = database.UpdateData(newUpdateData);
        //    if (result > 0)
        //        return RedirectToAction("SelectAllData");

        //    return View();
        //}
        //public ActionResult DeleteData(int id)
        //{
        //    Database database = new Database();
        //    var data = database.DeleteData(id);
        //    return RedirectToAction("SelectAllData");
        //}
    }
}