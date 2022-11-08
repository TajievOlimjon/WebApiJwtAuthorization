using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;
using WebApi.Entities;

namespace WebApi.ConfigurationServices.ConfigurationModels
{
    public class BookAuthorConfigurationService : IEntityTypeConfiguration<BookAuthor>
    {
        public void Configure(EntityTypeBuilder<BookAuthor> builder)
        {
            builder
               .HasKey(bc => new { bc.BookId, bc.AuthorId });
            builder
                .HasOne(bc => bc.Book)
                .WithMany(b => b.Authors)
                .HasForeignKey(bc => bc.BookId);
           builder
                .HasOne(bc => bc.Author)
                .WithMany(c => c.Books)
                .HasForeignKey(bc => bc.BookId);

        }
    }
}
