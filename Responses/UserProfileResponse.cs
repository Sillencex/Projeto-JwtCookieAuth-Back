namespace JwtCookieAuth.Responses
{
    public class UserProfileResponse
    {
        public Guid UserId { get; set; }
        public string Username { get; set; } = string.Empty;
    }
}
