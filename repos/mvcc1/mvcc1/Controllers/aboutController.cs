﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcc1.Controllers
{
    public class aboutController : Controller
    {
        // GET: about
        public ActionResult Index()
        {
            return View();
        }
    }
}