using JwtCookieAuth.Commons;
using JwtCookieAuth.Domain.Entities;
using JwtCookieAuth.Dtos.Requests;

namespace JwtCookieAuth.Interfaces
{
    public interface IAuthUserService
    {
        Task<Result<User>> AuthenticateAsync(LoginRequest request);
        Task<Result> RegisterAsync(RegisterRequest request);
    }
}
