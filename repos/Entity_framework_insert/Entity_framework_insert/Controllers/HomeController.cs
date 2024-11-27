using Entity_framework_insert.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Entity_framework_insert.Controllers
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
            datalayer Dl=new datalayer();

            using (var btpsContext = new btpsEntities())         //btps (database) ka object
            {
                var entity = new Entity                    //table (Entity) ka object
                {
                   name=data.name,
                   age=data.age,
                   phone=data.phone,
                };

                btpsContext.Entities.Add(entity);
                int result = btpsContext.SaveChanges();


            }
            return View();
        }
    }

}