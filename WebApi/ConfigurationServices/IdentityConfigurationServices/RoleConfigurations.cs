using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApi.Models;

namespace WebApi.ConfigurationServices.IdentityConfigurationServices
{
    public class RoleConfigurations : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            var roles = new List<IdentityRole>
            {
            new()
                    {
                        Id = new Guid("25478344-3d0d-42fc-a722-99e45353a08e").ToString(),
                        Name  = "Manager",
                        NormalizedName = "MANAGER",
                    }
                  
            };
            builder.HasData(roles);
        }
    }
}
