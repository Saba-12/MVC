using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeHubPortal.Domain.Entities
{
    public class Article
    {
        public int ArticleID { get; set; }
        [Required]

        public string Title { get; set; }
        [Required]

        public string ArticleUrl { get; set; }  

        public string Description { get; set; }

        public Category Category { get; set; }

        public int CategoryID { get; set; }

        public bool IsApproved { get; set; }

        public string Contributor { get; set; }

        public DateTime DateSubmited { get; set; }
    }
}
