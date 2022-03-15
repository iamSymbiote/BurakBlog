using BurakBlog.Shared.Entities.Abstract;

namespace BurakBlog.Entities.Concrete
{
    public class Article : EntityBase, IEntity
    {
        public string? Title { get; set; }
        public string? Content { get; set; }
        public string? Thumbnail { get; set; }
        public DateTime Date { get; set; } // arka tarafta tuttugumuz CreatedDate'den farkli, kullanici veya admin'in gorecegi tarih icin.
        public int ViewsCount { get; set; } = 0;
        public int CommentCount { get; set; } = 0;
        public string? SeoAuthor { get; set; } // bu ve alttaki uclu SEO icin, ilerde header'a gommus olacagiz bunlari.
        public string? SeoDescription { get; set; }
        public string? SeoTags { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; } // bir article'in 1 kategorisi olacak ve onu paylasan bir 'user' olacak.
        public int UserId { get; set; }
        public User? User { get; set; }
        public ICollection<Comment>? Comments { get; set; }
    }
}
