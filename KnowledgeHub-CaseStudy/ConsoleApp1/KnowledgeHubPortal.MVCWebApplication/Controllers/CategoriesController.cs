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
            //return a view for collecting category detail from user
            return View();
        }



        [HttpPost]
        public ActionResult Create(Category category)
        {
            //Validate the input
            //if(string.IsNullOrEmpty(category.Name))
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



        public ActionResult Delete(int id)
        {
            //fetch the remaining info from db by id
            Category categoryToDelete = repo.GetCategories(id);
            //return that info the view for confirmation
            return View(categoryToDelete);
        }

        public ActionResult DeleteConfirm(int id)
        {
            bool isDone = repo.RemoveCategory(id);
            return RedirectToAction("Index");
        }
    }
}