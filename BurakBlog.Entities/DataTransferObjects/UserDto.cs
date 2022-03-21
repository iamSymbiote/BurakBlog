using BurakBlog.Entities.Concrete;
using BurakBlog.Shared.Entities.Abstract;

namespace BurakBlog.Entities.DataTransferObjects
{
    public class UserDto : DtoGetBase
    {
        public User User { get; set; }
    }
}
