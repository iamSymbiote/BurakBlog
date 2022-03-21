using BurakBlog.Shared.Entities.Abstract;
using Microsoft.AspNetCore.Identity;

namespace BurakBlog.Entities.Concrete
{
    public class User : IdentityUser<int>
    {
        public string Picture { get; set; }
        public ICollection<Article> Articles { get; set; }
    }
}
