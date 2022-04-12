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
    public class ApprovedUrlController : Controller
    {
        IKnowledgeHubProtalRepository repo = new KnowledgeHubProtalRepository();
        //Get Approved Url

        [HttpGet]
        public ActionResult IndexURL()
        {
            var articles = repo.GetArticles();
            return View(articles);
        }        
    }
}