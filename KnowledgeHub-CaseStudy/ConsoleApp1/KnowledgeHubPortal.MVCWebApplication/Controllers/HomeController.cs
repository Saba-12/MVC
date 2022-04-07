using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KnowledgeHubPortal.MVCWebApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Knowledege Hub Portal description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact us.";

            return View();
        }
    }
}