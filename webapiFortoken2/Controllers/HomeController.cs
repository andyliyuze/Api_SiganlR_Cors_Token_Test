using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace webapiFortoken2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var request = Request;
            ViewBag.Title = "Home Page";

            return View();
        }
        public ActionResult TokenIndex()
        {
            var request = Request;
            return View();

        }
    }
}
