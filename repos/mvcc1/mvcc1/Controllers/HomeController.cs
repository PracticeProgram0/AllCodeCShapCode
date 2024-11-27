using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcc1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
      
        
        
        
        public ActionResult Index()
        {
            ViewBag.Username = "BTPS";
            ViewData["Password"] = "12345";
            var userstatus = 1;
            if (userstatus == 1)
            {
                ViewBag.user = "ok";
            }
            else {
                ViewBag.user = "Not ok";
            }


            return View();
        }
        
        }
    }
