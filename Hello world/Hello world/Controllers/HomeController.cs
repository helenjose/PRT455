using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hello_world.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "About Sports Management.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "PRT 455 Group B.";

            return View();
        }
    }
}