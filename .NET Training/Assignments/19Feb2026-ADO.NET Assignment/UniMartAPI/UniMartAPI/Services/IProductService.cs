using UniMartAPI.DTOs.Product;
using UniMartAPI.Models;

namespace UniMartAPI.Services
{
    public interface IProductService
    {
        Task<(List<ProductResponseDto> Items, int TotalCount)> GetAllAsync(
            int page,
            int pageSize,
            int? categoryId,
            string? search,
            string? sortBy,
            string? sortOrder
            );
        Task<Product?> GetByIdAsync(int id);
        Task<Product> CreateAsync(CreateProductDto dto, int userId);
        Task<bool> UpdateAsync(int id, Product product);
        Task<bool> DeleteAsync(int id);
    }
}
