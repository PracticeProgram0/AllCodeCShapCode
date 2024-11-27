using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Entity_framework.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Student data)
        {
            using (var DbContext = new mvcEntity())
            {
                var entity
            }
                return View();
        }
    }
}