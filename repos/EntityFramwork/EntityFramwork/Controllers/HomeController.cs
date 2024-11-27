using EntityFramwork.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace EntityFramwork.Controllers
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
            Database database = new Database();
            if (data != null)
            {
                int result=database.DataInsert(data);
                ViewBag.info = "Data Insertedd Successfully ";
                if (result > 0) 
                { 
                    return RedirectToAction("SelectAllData");                
                }

            }
                return View();
        }
        // Select data from table all
        public ActionResult SelectAllData()
        {
            Database database = new Database(); 
            var data=database.SelectAllData();
            return View(data);
        }
                
        public ActionResult GetData(int id)
        {
            Database database = new Database();
            var data= database.SelectData(id);
            return View(data);
        }
        public ActionResult UpdateData (int id) 
        {
            Database database = new Database();
            var data = database.SelectData(id);
            
            return View(data);
        }
        [HttpPost]
        public ActionResult UpdateData(MVCBatch newUpdateData)
        {
            Database database = new Database();
            var result = database.UpdateData(newUpdateData);
            if (result > 0)
                return RedirectToAction("SelectAllData");

            return View();
        }
        public ActionResult DeleteData(int id)
        {
            Database database = new Database();
            var data = database.DeleteData(id);
            return RedirectToAction("SelectAllData");
        }
       
        public ActionResult Email()
        {
            return View();       
        }
    }
}