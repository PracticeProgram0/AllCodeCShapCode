using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCC3.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        //public ActionResult Index()
        //{
        //    return View();
        //}
        public string Index()
        {
            return (" manish yadev......");
        }
        public string emp(String name)
        {

            return name;
        }
        public string student(String id,String name)
        {

            return $"ID is :{id}and name is :{name}";
        }
    }
}