using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TroyTriviaWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "About";

            return View();
        }

        public ActionResult Questions()
        {
            ViewBag.Message = "Questions";

            return View();
        }

        public ActionResult Locations()
        {
            ViewBag.Message = "Locations";

            return View();
        }

        public ActionResult Teams()
        {
            ViewBag.Message = "Teams";

            return View();
        }
    }
}