using BurakBlog.DataBase.Abstract;
using BurakBlog.DataBase.Concrete;
using BurakBlog.DataBase.Concrete.EntityFramework.Contexts;
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
            serviceCollection.AddScoped<IUnitOfWork, UnitOfWork>();
            serviceCollection.AddScoped<ICategoryService, CategoryManager>();
            serviceCollection.AddScoped<IArticleService, ArticleManager>();
            return serviceCollection;
        }
    }
}
