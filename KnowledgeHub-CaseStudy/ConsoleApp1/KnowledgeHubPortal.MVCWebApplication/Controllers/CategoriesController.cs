using KnowledgeHubPortal.Data;
using KnowledgeHubPortal.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KnowledgeHubPortal.MVCWebApplication.Controllers
{
    public class CategoriesController : Controller
    {
        IKnowledgeHubProtalRepository repo = new KnowledgeHubProtalRepository();
        public ActionResult Index()
        {
            //get all categories from model and pass it to view
            var categories = repo.GetCategories();

            return View(categories);
        }

        [HttpGet]
        public ActionResult Create()
        {
            //return a view for collecting category details from user
            return View();
        }

        [HttpPost]
        public ActionResult Save()
        {
            throw new NotImplementedException();
        }
    }
}