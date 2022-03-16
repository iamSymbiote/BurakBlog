using BurakBlog.Entities.Concrete;
using BurakBlog.Shared.Entities.Abstract;

namespace BurakBlog.Entities.DataTransferObjects
{
    public class CategoryListDto : DtoGetBase
    {
        public IList<Category> Categories { get; set; }
    }
}
