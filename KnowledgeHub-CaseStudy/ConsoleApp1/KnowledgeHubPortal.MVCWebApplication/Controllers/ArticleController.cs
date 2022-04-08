using KnowledgeHubPortal.Data;
using KnowledgeHubPortal.Domain.Entities;
using KnowledgeHubPortal.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KnowledgeHubPortal.MVCWebApplication.Controllers
{
    public class ArticleController : Controller
    {
        IKnowledgeHubProtalRepository repo = new KnowledgeHubProtalRepository();
        // GET: Article
        public ActionResult Submit()
        {
            return View();
        }
        
        [HttpPost]

        public ActionResult Submit(Article article)
        {

            if (!ModelState.IsValid)
            {
                return View("Create", category);
            }

            //persist the data
            repo.SaveCategory(category);
            //return view
            // var categories = repo.GetCategories();
            //return View("Index", categories);
            return RedirectToAction("Index");

        }
    }
}