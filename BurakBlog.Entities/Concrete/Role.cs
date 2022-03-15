using BurakBlog.Shared.Entities.Abstract;

namespace BurakBlog.Entities.Concrete
{
    public class Role : EntityBase, IEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<User> Users { get; set; } // 1 rol birden fazla user'a sahip olabilir ama 1 USER tek bir role sahip olacak.
    }
}
