using UniMartAPI.DTOs.User;

namespace UniMartAPI.Services
{
    public interface IAuthService
    {
        Task<UserProfileDto> GetProfileAsync(int userId);
    }
}
