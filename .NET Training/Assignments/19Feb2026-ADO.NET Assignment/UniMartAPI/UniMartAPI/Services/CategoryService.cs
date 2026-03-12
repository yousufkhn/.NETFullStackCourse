using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using UniMartAPI.Data;
using UniMartAPI.DTOs.Category;
using UniMartAPI.DTOs.Product;

namespace UniMartAPI.Services
{
    public class CategoryService : ICategoryService
    {
        public readonly UniMartDbContext _context;

        public CategoryService(UniMartDbContext context)
        {
            _context = context;
        }

        public async Task<List<CategoryResponseDto>> GetAllAsync()
        {
            var categories = await _context.Categories.Select(c => new CategoryResponseDto
            {
                CategoryId = c.CategoryId,
                Name = c.Name,
            }).ToListAsync();

            return categories;
        }

    }
}
