using BurakBlog.DataBase.Abstract;
using BurakBlog.DataBase.Concrete;
using BurakBlog.DataBase.Concrete.EntityFramework.Contexts;
using BurakBlog.Entities.Concrete;
using BurakBlog.Services.Abstract;
using BurakBlog.Services.Concrete;
using Microsoft.Extensions.DependencyInjection;

namespace BurakBlog.Services.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection LoadMyServices (this IServiceCollection serviceCollection)
        {
            serviceCollection.AddDbContext<BurakBlogContext>();
            serviceCollection.AddIdentity<User, Role>(options =>
            {
                // User Password detaylarini verdigimiz kisim.
                options.Password.RequireDigit = false;
                options.Password.RequiredLength = 5;
                options.Password.RequiredUniqueChars = 0;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;

                // User USERNAME ve EMAIL ayarlari asagida.

                options.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
                options.User.RequireUniqueEmail = true;
            }).AddEntityFrameworkStores<BurakBlogContext>();
            serviceCollection.AddScoped<IUnitOfWork, UnitOfWork>();
            serviceCollection.AddScoped<ICategoryService, CategoryManager>();
            serviceCollection.AddScoped<IArticleService, ArticleManager>();
            return serviceCollection;
        }
    }
}
