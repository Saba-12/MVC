using KnowledgeHubPortal.Data;
using KnowledgeHubPortal.Domain.Entities;
using KnowledgeHubPortal.Domain.Repository;
using KnowledgeHubPortal.MVCWebApplication.Models;
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

        public ActionResult Index()
        {
            var articleToBrowse = (from a in repo.BrowseArticles()
                                   select new ArticleBrowseViewModel
                                   {
                                       Title = a.Title,
                                       ArticleUrl = a.ArticleUrl,
                                       Description = a.Description,
                                       Contributor = a.Contributor
                                   }).ToList();
            return View(articleToBrowse);
        }


        [HttpGet]
        public ActionResult Submit()
        {
            var dropDownData = from c in repo.GetCategories()
                               select new SelectListItem { Value = c.CategoryId.ToString(), Text = c.Name };
            dropDownData.Prepend(new SelectListItem { Text = "Select Category" });
            ViewBag.CategoryID = dropDownData;
            return View();
        }



        [HttpPost]
        public ActionResult Submit(ArticleSubmitViewModel article)
        {
            if (!ModelState.IsValid)
                return View(article);

            //convert view model to domain model - manually or auto (Automapper)
            Article articleToSubmit = new Article
            {
                Title = article.Title,
                ArticleUrl = article.ArticleUrl,
                Description = article.Description,
                CategoryID = article.CategoryID,
                IsApproved = false,
                DateSubmited = DateTime.Now,
                Contributor = User.Identity.Name
            };



            repo.SubmitArticle(articleToSubmit);
            TempData["Message"] = $"The article {articleToSubmit.Title} is submitted successfully";

            //send email to admin
            return RedirectToAction("Submit");
        }
    }
}