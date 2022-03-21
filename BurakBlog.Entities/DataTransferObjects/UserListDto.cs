using BurakBlog.Entities.Concrete;
using BurakBlog.Shared.Entities.Abstract;

namespace BurakBlog.Entities.DataTransferObjects
{
    public class UserListDto : DtoGetBase
    {
        public IList<User> Users { get; set; }
    }
}
