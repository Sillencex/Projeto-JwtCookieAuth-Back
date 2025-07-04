using System.Security.Claims;
using JwtCookieAuth.Domain.Entities;

namespace JwtCookieAuth.Interfaces
{
    public interface ITokenService
    {
        string GenerateToken(User user, TimeSpan? expiration = null);
        ClaimsPrincipal? ValidateToken(string token);
    }
}
