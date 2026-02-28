using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Security.Claims;
using UniMartAPI.Data;
using UniMartAPI.DTOs.Product;
using UniMartAPI.Models;


namespace UniMartAPI.Services
{
    public class ProductService : IProductService
    {
        public readonly UniMartDbContext _context;

        public ProductService(UniMartDbContext context)
        {
            _context = context;
        }
        public async Task<Product> CreateAsync(CreateProductDto dto,int userId)
        {

            var product = new Product
            {
                Name = dto.Name,
                Description = dto.Description,
                Price = dto.Price,
                CategoryId = dto.CategoryId,
                UserId = userId,
                CreatedAt = DateTime.UtcNow,
                IsActive = true
            };
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return product;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return false;
            }

            _context.Products.Remove(product);

            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<(List<ProductResponseDto>,int)> GetAllAsync(
            int page,
            int pageSize,
            int? categoryId,
            string? search,
            string? sortBy,
            string? sortOrder
            )
        {
            var query = _context.Products
                .Include(p => p.User)
                .Include(p => p.Category)
                .Where(p => p.IsActive)
                .AsQueryable();

            // category filter
            if (categoryId.HasValue)
            {
                query = query.Where(p => p.CategoryId == categoryId.Value);
            }

            // search
            if (!string.IsNullOrWhiteSpace(search))
            {
                query = query.Where(p =>
                    p.Name.Contains(search) ||
                    p.Description!.Contains(search));
            }

            // sorting
            if (!string.IsNullOrEmpty(sortBy))
            {
                if(sortBy.ToLower() == "price")
                {
                    query = sortOrder == "desc" ? query.OrderByDescending(p => p.Price) : query.OrderBy(p => p.Price);
                }
                else if(sortBy.ToLower() == "createdat")
                {
                    query = sortOrder == "desc" ? query.OrderByDescending(p => p.CreatedAt) : query.OrderBy(p => p.CreatedAt);
                }
            }
            else
            {
                query = query.OrderByDescending(p => p.CreatedAt);
            }

            var totalCount = await query.CountAsync();

            var items = await query
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .Select(p => new ProductResponseDto
                {
                    ProductId = p.ProductId,
                    Name = p.Name,
                    Description = p.Description,
                    Price = p.Price,
                    Category = p.Category.Name,
                    SellerName = p.User.FullName,
                    SellerPhone = p.User.PhoneNumber,
                    CreatedAt = p.CreatedAt
                }).ToListAsync();

            return (items, totalCount);
                      
        }

        public async Task<Product?> GetByIdAsync(int id)
        {
            return await _context.Products.FindAsync(id);
        }

        public async Task<bool> UpdateAsync(int id, Product product)
        {
            var existing = await _context.Products.FindAsync(id);

            if (existing == null)
                return false;

            existing.Name = product.Name;
            existing.Price = product.Price;

            await _context.SaveChangesAsync();
            return true;
        }
    }
}
