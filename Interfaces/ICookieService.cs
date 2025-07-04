namespace JwtCookieAuth.Interfaces
{
    public interface ICookieService
    {
        void SetJwtCookie(HttpResponse response, string token, TimeSpan expiration);
        void ClearJwtCookie(HttpResponse response);
    }
}
