using UniMartAPI.DTOs.Category;

namespace UniMartAPI.Services
{
    public interface ICategoryService
    {
        Task<List<CategoryResponseDto>> GetAllAsync();
    }
}
