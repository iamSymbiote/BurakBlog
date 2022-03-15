using BurakBlog.Entities.Concrete;
using BurakBlog.Shared.Data.Abstract;

namespace BurakBlog.DataBase.Abstract
{
    public interface ICategoryRepository : IEntityRepository<Category>
    {
    }
}
