using JwtCookieAuth.Responses;

namespace JwtCookieAuth.Interfaces
{
    public interface IUserService
    {
        Task<UserProfileResponse> GetUserProfileAsync(Guid userId);
    }
}
