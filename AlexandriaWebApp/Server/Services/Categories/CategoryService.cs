using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlexandriaWebApp.Server.Data;
using AlexandriaWebApp.Server.Models;
using AlexandriaWebApp.Shared.Models.Category;
using Microsoft.EntityFrameworkCore;

namespace AlexandriaWebApp.Server.Services.Categories
{
    public class CategoryService : ICategoryService
    {
        private readonly ApplicationDbContext _context;
        private string _userId;

        public CategoryService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> CreateCategoryAsync(CategoryCreate model)
        {
            if (model == null) return false;

            var categoryEntity = new Category
            {
                Name = model.Name
            };

            _context.Categories.Add(categoryEntity);
            return await _context.SaveChangesAsync() == 1;
        }

        public Task<bool> DeleteCategoryAsync(int categoryId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<CategoryListItem>> GetAllCategoriesAsync()
        {
            var categoryQuery =
                _context.Categories
                .Select(entity =>
                new CategoryListItem
                {
                    Id = entity.Id,
                    Name = entity.Name,
                });

            return await categoryQuery.ToListAsync();
        }

        public Task<CategoryDetail> GetCategoryByIdAsync(int categoryId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateCategoryAsync(CategoryEdit model)
        {
            throw new NotImplementedException();
        }

        public void SetUserId(string userId) => _userId = userId;
    }
}
