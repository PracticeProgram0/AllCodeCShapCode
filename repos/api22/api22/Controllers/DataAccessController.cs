using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace api22.Controllers
{
    public class DataAccessController : Controller
    {
        [System.Web.Http.HttpGet]
       

        // GET: DataAccess
        public IHttpActionResult Index()
        {
            using (var context = new ViVEKEntities())
            {
                var data = context.ImageUploades.ToList();

                return view(data);
            }
        }

        private IHttpActionResult view(object data)
        {
            throw new NotImplementedException();
        }
    }
}