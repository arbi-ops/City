﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Qyteti.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Ulqin.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Tivar.";

            return View();
        }
    }
}