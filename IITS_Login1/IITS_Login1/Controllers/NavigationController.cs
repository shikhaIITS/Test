using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IITS_Login1.Controllers
{
    public class NavigationController : Controller
    {
        // GET: Navigation
        public ActionResult Nav()
        {
            return View();
        }
        public ActionResult Header()
        {
            return View();
        }
    }
}