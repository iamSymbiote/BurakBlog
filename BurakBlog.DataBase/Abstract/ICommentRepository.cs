using BurakBlog.Entities.Concrete;
using BurakBlog.Shared.Data.Abstract;

namespace BurakBlog.DataBase.Abstract
{
    public interface ICommentRepository : IEntityRepository<Comment>
    {
    }
}
