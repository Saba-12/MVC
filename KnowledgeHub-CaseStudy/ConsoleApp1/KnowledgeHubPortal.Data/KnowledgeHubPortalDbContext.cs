using KnowledgeHubPortal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeHubPortal.Data
{
    internal class KnowledgeHubPortalDbContext:DbContext
    {
        public KnowledgeHubPortalDbContext():base("name=DefaultConnection")
        {

        }

        public DbSet<Category> Categories { get; set; }
    }
}
