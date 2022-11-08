using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using WebApi.Entities;

namespace WebApi.ConfigurationServices.ConfigurationModels
{
    public class BookConfigurationService : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.ToTable("Books");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                   .HasColumnName("Id")
                   .HasColumnType("uuid")
                   .HasDefaultValueSql("gen_random_uuid()")    // Use 
                   .IsRequired();
            //builder.HasKey(x => x.Id);
            //builder.Property(x => x.Id)
            //       .HasColumnName("Id")
            //       .HasColumnType("uuid")
            //       .HasDefaultValueSql("gen_random_uuid()")
            //       .IsRequired();
        }
    }
}
