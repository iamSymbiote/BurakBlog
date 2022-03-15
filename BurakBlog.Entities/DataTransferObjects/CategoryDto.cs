using BurakBlog.Entities.Concrete;
using BurakBlog.Shared.Entities.Abstract;

namespace BurakBlog.Entities.DataTransferObjects
{
    public class CategoryDto : DtoGetBase
    {
        public Category Category { get; set; }
    }
}
