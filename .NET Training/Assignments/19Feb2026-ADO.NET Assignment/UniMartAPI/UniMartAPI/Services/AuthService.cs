using Microsoft.EntityFrameworkCore;
using UniMartAPI.Data;
using UniMartAPI.DTOs.User;

namespace UniMartAPI.Services
{
    public class AuthService : IAuthService
    {
        public readonly UniMartDbContext _context;

        public AuthService(UniMartDbContext context)
        {
            _context = context;
        }

        public async Task<UserProfileDto> GetProfileAsync(int userId)
        {
            var user = await _context.Users
                .Where(u => u.UserId == userId)
                .Select(u => new UserProfileDto
                {
                    UserId = u.UserId,
                    Name = u.FullName,
                    Email = u.Email,
                    ProductCount = u.Products.Count,

                    Products = u.Products
                        .OrderByDescending(p => p.CreatedAt)
                        .Select(p => new UserProductDto
                        {
                            ProductId = p.ProductId,
                            Title = p.Name,
                            Price = p.Price,
                            CreatedAt = p.CreatedAt
                        }).ToList()
                })
                .FirstOrDefaultAsync();

            return user;
        }
    }
}
