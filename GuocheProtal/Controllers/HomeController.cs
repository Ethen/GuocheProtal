using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GuocheProtal.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Index = 1;
            return View();
        }

        public ActionResult Service()
        {
            ViewBag.Index = 3;
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Product()
        {
            ViewBag.Index = 2;
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Index = 4;
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Index = 5;
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}