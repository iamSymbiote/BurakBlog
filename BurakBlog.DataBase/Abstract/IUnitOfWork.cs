namespace BurakBlog.DataBase.Abstract
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        IArticleRepository Articles { get; } // amacimiz unitofwork.Articles ile ulasabilmek
        ICategoryRepository Categories { get; }
        ICommentRepository Comments { get; }
      
        //yani ilerde bunlari cagirirken mesela;
        //    _unitOfWork.Categories.AddAsync(category);
        //    _unitOfWork.Users.AddAsync(user);
        //    _unitOfWork.SaveAsync();   <<< diyerek database'e kayit ettirebilecegiz. Yukardakilerden biri patlarsa save edemeyecek, debuglayip kontrolu daha kolay saglariz boylece.
        Task<int> SaveAsync();
    }
}
