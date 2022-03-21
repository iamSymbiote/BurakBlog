﻿using BurakBlog.DataBase.Abstract;
using BurakBlog.DataBase.Concrete.EntityFramework.Contexts;
using BurakBlog.DataBase.Concrete.EntityFramework.Repositories;

namespace BurakBlog.DataBase.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BurakBlogContext _context;
        private EfArticleRepository _articleRepository;
        private EfCategoryRepository _categoryRepository;
        private EfCommentRepository _commentRepository;
        public UnitOfWork(BurakBlogContext context)
        {
            _context = context;
        }

        // asagidaki `??` operatorunun amaci; bir degiskenin degerinin `null` olabilecegi durumlarda alternatif deger dondurebilmek. //
        public IArticleRepository Articles => _articleRepository ?? new EfArticleRepository(_context);

        public ICategoryRepository Categories => _categoryRepository ?? new EfCategoryRepository(_context);

        public ICommentRepository Comments => _commentRepository ?? new EfCommentRepository(_context);

        public async ValueTask DisposeAsync()
        {
            await _context.DisposeAsync();
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
