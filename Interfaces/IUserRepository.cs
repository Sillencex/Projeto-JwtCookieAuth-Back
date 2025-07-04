using JwtCookieAuth.Domain.Entities;

namespace JwtCookieAuth.Interfaces
{
    public interface IUserRepository
    {
        Task<User?> GetByIdAsync(Guid id);
        Task<User?> GetByUsernameAsync(string username);
        Task<bool> ExistsByUsernameAsync(string username);
        Task AddAsync(User user);
    }
}
