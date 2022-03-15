using BurakBlog.DataBase.Concrete.EntityFramework.Mappings;
using BurakBlog.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace BurakBlog.DataBase.Concrete.EntityFramework.Contexts
{
    public class BurakBlogContext : DbContext
    {
        public DbSet<Article>? Articles { get; set; }
        public DbSet<Category>? Categories { get; set; }
        public DbSet<Comment>? Comments { get; set; }
        public DbSet<Role>? Roles { get; set; }
        public DbSet<User>? Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            string connectionString = "server=.\\SQLEXPRESS;database=BurakBlog;trusted_connection=true;multipleactiveresultsets=true;";

            optionsBuilder.UseSqlServer(connectionString);

            //optionsBuilder.UseSqlServer(connectionString: "server=.;database=BurakBlog;trusted_connection=true;multipleactiveresultsets=true;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ArticleMap());
            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new CommentMap());
            modelBuilder.ApplyConfiguration(new RoleMap());
            modelBuilder.ApplyConfiguration(new UserMap());
        }
    }
}
