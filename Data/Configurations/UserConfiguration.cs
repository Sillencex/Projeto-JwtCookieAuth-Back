using JwtCookieAuth.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JwtCookieAuth.Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");

            builder.HasKey(u => u.Id);

            builder.Property(u => u.Id).IsRequired();

            builder.Property(u => u.Username).IsRequired().HasMaxLength(100);

            builder.Property(u => u.PasswordHash).IsRequired().HasMaxLength(255);

            builder.HasIndex(u => u.Username).IsUnique();
        }
    }
}
