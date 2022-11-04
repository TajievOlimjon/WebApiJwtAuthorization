using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using WebApi.Models;
using Microsoft.AspNetCore.Identity;

namespace WebApi.ConfigurationServices.IdentityConfigurationServices
{
    public class UserConfigurations : IEntityTypeConfiguration<IdentityUser>
    {
        public void Configure(EntityTypeBuilder<IdentityUser> builder)
        {
            PasswordHasher<User> passwordHasher = new PasswordHasher<User>();
            var users = new User
            {
                Id = new Guid("6ba8307e-74cc-4643-b7eb-278f6320f1af").ToString(),
                FirstName="Aziz",
                LastName="Azizov",
                MiddleName="Azizovich",
                UserName = "Admin",
                NormalizedUserName="ADMIN",
                Email = "Aziz@gmail.com",
                EmailConfirmed=true,
                PhoneNumber="+992988058314",
                PhoneNumberConfirmed=true
          };
            var passwordHash = passwordHasher.HashPassword(users, "12345");
            users.PasswordHash = passwordHash;
            builder.HasData(users);
        }
    }
}
