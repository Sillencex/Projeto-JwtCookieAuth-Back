using JwtCookieAuth.Interfaces;

namespace JwtCookieAuth.Services
{
    public class CookieService : ICookieService
    {
        private readonly bool _isProduction;

        public CookieService(IHostEnvironment env)
        {
            _isProduction = env.IsProduction();
        }

        public void SetJwtCookie(HttpResponse response, string token, TimeSpan expiration)
        {
            response.Cookies.Append(
                "jwtToken",
                token,
                new CookieOptions
                {
                    HttpOnly = true,
                    Secure = _isProduction,
                    SameSite = _isProduction ? SameSiteMode.Strict : SameSiteMode.Lax,
                    Expires = DateTime.UtcNow.Add(expiration),
                }
            );
        }

        public void ClearJwtCookie(HttpResponse response)
        {
            response.Cookies.Delete("jwtToken");
        }
    }
}
