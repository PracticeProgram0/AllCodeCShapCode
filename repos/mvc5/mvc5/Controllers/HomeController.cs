﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc5.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index1()
        {
            return View();
        }
        public ActionResult About1()
        {
            return View();
        }
        public ActionResult Contact1()
        {
            return View();
        }
    }
}