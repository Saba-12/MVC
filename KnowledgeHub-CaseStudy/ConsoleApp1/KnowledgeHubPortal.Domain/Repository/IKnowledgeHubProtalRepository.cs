using KnowledgeHubPortal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeHubPortal.Domain.Repository
{
    public interface IKnowledgeHubProtalRepository
    {
        #region Category CRUD
        bool SaveCategory(Category catagory);

        List<Category> GetCategories();
        Category GetCategories(int id);
        bool RemoveCategory(int id);
        void EditCategory(Category category);
        object GetArticles();
        #endregion


        #region Articles Management
        void SubmitArticle(Article article);

        List<Article> BrowseArticles();

        void ApproveArticles(List<int> articleIds);

        void RejectArticles(List<int> articleIds);
        //bool IsSubmit(Article article);
        //bool SaveArticle(Article article);
        #endregion
    }
}
