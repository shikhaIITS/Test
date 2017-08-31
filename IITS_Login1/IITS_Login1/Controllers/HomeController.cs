﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IITS_Login1.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public HomeController()
        {
            //if (User == null)
            //    RedirectToAction("Login", "Account");
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}