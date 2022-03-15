using BurakBlog.Entities.Concrete;
using BurakBlog.Shared.Entities.Abstract;
using BurakBlog.Shared.Utilities.Results.ComplexTypes;

namespace BurakBlog.Entities.DataTransferObjects
{
    public class ArticleDto : DtoGetBase
    {
        public Article Article { get; set; }
    }
}
