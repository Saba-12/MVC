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

        public void EditCategory(Category category)
        {

            db.Entry(category).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        public List<Category> GetCategories()
        {
            return db.Categories.ToList();
        }

        public Category GetCategories(int id)
        {
            return db.Categories.Find(id);
        }

        public bool RemoveCategory(int id)
        {
            var cat = db.Categories.Remove(GetCategories(id));
            db.SaveChanges();
            if (cat != null)
                return true;
            else
                return false;
        }

        public bool SaveCatagory(Category catagory)
        {
            db.Categories.Add(catagory);
            int count = db.SaveChanges();
            return count >= 1;
        }

        public bool SaveCategory(Category category)
        {
            db.Categories.Add(category);
            int count = db.SaveChanges();
            return count >= 1;
        }
    }
}
