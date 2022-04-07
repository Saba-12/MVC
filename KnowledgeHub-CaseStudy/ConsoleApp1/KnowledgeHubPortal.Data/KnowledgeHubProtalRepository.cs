using KnowledgeHubPortal.Domain.Entities;
using KnowledgeHubPortal.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeHubPortal.Data
{
    public class KnowledgeHubProtalRepository: IKnowledgeHubProtalRepository
    {
        private readonly KnowledgeHubPortalDbContext db = new KnowledgeHubPortalDbContext();

        public List<Category> GetCategories()
        {
            return db.Categories.ToList();
        }

        public bool SaveCatagory(Category catagory)
        {
            db.Categories.Add(catagory);
            int count = db.SaveChanges();
            return count >= 1;
        }
    }
}
