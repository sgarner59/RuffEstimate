using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RuffEstimate.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "So, you want to be a dog owner?";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "For more information please contact us at";

            return View();
        }
    }
}