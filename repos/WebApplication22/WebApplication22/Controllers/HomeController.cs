using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication22.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public string Index1(int id)
        {
            return "Index1 value is '"+id+"'";
        }
        public string Index2(int id,string name)
        {
            return "Id is:{100} and name is :{shyam}";
        }
        public ActionResult Index3()
        {
            return View();
        }
    }
}