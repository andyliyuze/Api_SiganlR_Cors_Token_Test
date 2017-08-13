using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebForPc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult TokenIndex() { return View(); }
        public ActionResult  Index() { return View(); }
    }
}