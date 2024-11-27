using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace api22.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            HttpClient client=new HttpClient();

            client.BaseAddress = new Uri("          ");

            var response = client.GetAsync("DataAccess");
            response.Wait();
            var data=response.Result;
            if(data.IsSuccessStatusCode)
            {
                var demodata = data.Content.ReadAsAsync<List<Imageupload>>();
                demodata.Wait();
                List<ImageUploade> list = demodata.Result;
                return View(list);
            }
            return View();
        }
        public ActionResult Google()
        {
            HttpClient client= new HttpClient();
            client.BaseAddress = new Uri("            ");
            var response = client.GetAsync("random");
            response.Wait();
            var data=response.Result;
            if(data.IsSuccessStatusCode)
            {
                return View(data);
            }
            return View();
        }
    }
}