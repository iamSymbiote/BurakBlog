using BurakBlog.DataBase.Abstract;
using BurakBlog.Entities.Concrete;
using BurakBlog.Shared.Data.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BurakBlog.DataBase.Concrete.EntityFramework.Repositories
{
    public class EfArticleRepository : EfEntityRepositoryBase<Article>, IArticleRepository
    {
        public EfArticleRepository(DbContext context) : base(context)
        {
        }
    }
}
