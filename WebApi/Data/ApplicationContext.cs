using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApi.ConfigurationServices.ConfigurationModels;
using WebApi.Entities;
using WebApi.Models;

namespace WebApi.Data
{
    public class ApplicationContext : IdentityDbContext<User>
    { 
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
           
        }

       

       
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.HasPostgresExtension("uuid-ossp");

            builder.Entity<BookAuthor>()
               .HasKey(bc => new { bc.BookId, bc.AuthorId });


            builder.ApplyConfiguration(new BookConfigurationService());

            builder.ApplyConfiguration(new AuthorConfigureService());

            builder.ApplyConfiguration(new BookAuthorConfigurationService());

            builder.Entity<CourseStudent>()
               .HasKey(bc => new { bc.CourseId, bc.StudentId });

            //SeedRoles(builder);
            //SeedUsers(builder);
            //SeedUserRoles(builder);
           
        }
        private void SeedUsers(ModelBuilder builder)
        {
            builder.Entity<User>().HasData(
           
                new User
                {
                      Id = new Guid("591963f3-4778-49c2-a565-32ebe9e4bbe7").ToString(),    //1
                      FirstName="Azizbek",
                      LastName="Azizov",
                      MiddleName="Azizovich",
                      UserName = "Azizbek",
                      NormalizedUserName="AZIZBEK",
                      Email = "Aziz@gmail.com",
                      EmailConfirmed=true,
                      PhoneNumber="+992988058314",
                      PhoneNumberConfirmed=true,
                      PasswordHash=BCrypt.Net.BCrypt.HashPassword("azizbek")
                },
                new User
                {
                      Id = new Guid("07a97ae7-a329-4534-9795-455aaeda7b74").ToString(),   //2
                      FirstName="Olimjon",
                      LastName="Tajiev",
                      MiddleName="Turamurodovich",
                      UserName = "TajievOlimjon",
                      NormalizedUserName="TAJIEVOLIMJON",
                      Email = "tajiev0711@gmail.com",
                      EmailConfirmed=true,
                      PhoneNumber="+992911288822",
                      PhoneNumberConfirmed=true,
                      PasswordHash=BCrypt.Net.BCrypt.HashPassword("1234")
                },
                new User
                {
                      Id = new Guid("3add81f0-3a56-45ff-adbe-7930786080ef").ToString(),  //3
                      FirstName="Azamjon",
                      LastName="Azamov",
                      MiddleName="Azamovich",
                      UserName = "Azamjon",
                      NormalizedUserName="AZAMJON",
                      Email = "azam@gmail.com",
                      EmailConfirmed=true,
                      PhoneNumber="+992988058310",
                      PhoneNumberConfirmed=true,
                      PasswordHash=BCrypt.Net.BCrypt.HashPassword("azam")
                },
                new User
                {
                      Id = new Guid("cc7e0bf4-b58a-4352-93c9-aca3efbcbd32").ToString(),  //4
                      FirstName="Akram",
                      LastName="Albekov",
                      MiddleName="Salimjonivich",
                      UserName = "Akram",
                      NormalizedUserName="AKRAM ",
                      Email = "akram@gmail.com",
                      EmailConfirmed=true,
                      PhoneNumber="+992988058312",
                      PhoneNumberConfirmed=true,
                      PasswordHash=BCrypt.Net.BCrypt.HashPassword("akram")
                },
                new User
                {
                      Id = new Guid("c2478fca-a65d-4e83-b377-7f5a06a89f19").ToString(),  //5
                      FirstName="Muhriddin",
                      LastName="Kalkanov",
                      MiddleName="Olimjonovich",
                      UserName = "Muhriddin",
                      NormalizedUserName="MUHRIDDIN",
                      Email = "muhriddin@gmail.com",
                      EmailConfirmed=true,
                      PhoneNumber="+992988058313",
                      PhoneNumberConfirmed=true,
                      PasswordHash=BCrypt.Net.BCrypt.HashPassword("muhriddin")
                },
                new User
                {
                      Id = new Guid("e5776d2b-d5c6-4afd-968c-280d74a797c0").ToString(),  //6
                      FirstName="Akmal",
                      LastName="Agamberdiev",
                      MiddleName="Akmalovich",
                      UserName = "Akmal",
                      NormalizedUserName="AKMAL",
                      Email = "Akmal@gmail.com",
                      EmailConfirmed=true,
                      PhoneNumber="+992988058315",
                      PhoneNumberConfirmed=true,
                      PasswordHash=BCrypt.Net.BCrypt.HashPassword("akmal")
                },
                new User
                {
                      Id = new Guid("4502a71c-0341-4d70-a84d-3ba2eee49287").ToString(),  //7
                      FirstName="Donior",
                      LastName="Tajiev",
                      MiddleName="Ashpulatovich",
                      UserName = "Donior",
                      NormalizedUserName="DONIOR",
                      Email = "donior@gmail.com",
                      EmailConfirmed=true,
                      PhoneNumber="+992988058317",
                      PhoneNumberConfirmed=true,
                      PasswordHash=BCrypt.Net.BCrypt.HashPassword("donior")
                },
                new User
                {
                      Id = new Guid("849e3092-76eb-4ad3-a41c-1a6236543ba2").ToString(),  //8
                      FirstName="Akbar",
                      LastName="Alimirzoev",
                      MiddleName="Alievich",
                      UserName = "Akbar",
                      NormalizedUserName="AKBAR",
                      Email = "akbar@gmail.com",
                      EmailConfirmed=true,
                      PhoneNumber="+992988058318",
                      PhoneNumberConfirmed=true,
                      PasswordHash=BCrypt.Net.BCrypt.HashPassword("akbar")
                }
            
            );
        }
        private void SeedRoles(ModelBuilder builder)
        {
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole()
                {
                    Id = new Guid("fa1774c4-5abd-48e9-a18c-0ffa7a83a765").ToString(),
                    Name = "Administrator",
                    NormalizedName = "ADMINISTRATOR",
                    ConcurrencyStamp = Guid.NewGuid().ToString()

                },
                 new IdentityRole()
                 {
                     Id = new Guid("c78fb03b-d522-49f9-b80e-45dda9a8fefe").ToString(),
                     Name = "Manager",
                     NormalizedName = "MANAGER",
                     ConcurrencyStamp = Guid.NewGuid().ToString()


                 },
                  new IdentityRole()
                  {
                      Id = new Guid("7f2ac4c5-734f-4490-84a8-9971c21a9132").ToString(),
                      Name = "Owner",
                      NormalizedName = "OWNER",
                      ConcurrencyStamp = Guid.NewGuid().ToString()

                  },
                   new IdentityRole()
                   {
                       Id = new Guid("5582d545-f8ac-48c2-8c69-927a1124961b").ToString(),
                       Name = "Editor",
                       NormalizedName = "EDITOR",
                       ConcurrencyStamp = Guid.NewGuid().ToString()

                   },
                    new IdentityRole()
                    {
                        Id = new Guid("e336c35c-f87c-4f77-a7e0-f4117851e295").ToString(),
                        Name = "Buyer",
                        NormalizedName = "BUYER",
                        ConcurrencyStamp = Guid.NewGuid().ToString()

                    },
                     new IdentityRole()
                     {
                         Id = new Guid("08e7e341-61bb-41ec-a419-e2fd8d42c380").ToString(),
                         Name = "Business",
                         NormalizedName = "BUSINESS",
                         ConcurrencyStamp = Guid.NewGuid().ToString()
                     },
                      new IdentityRole()
                      {
                          Id = new Guid("773e723b-225f-413d-b534-6b159f718875").ToString(),
                          Name = "Seller",
                          NormalizedName = "SELLER",
                          ConcurrencyStamp = Guid.NewGuid().ToString()
                      },
                       new IdentityRole()
                       {
                           Id = new Guid("8de6be3a-dc7a-497a-ae23-4c8acb39adb4").ToString(),
                           Name = "Subscriber",
                           NormalizedName = "SUBSCRIBER",
                           ConcurrencyStamp = Guid.NewGuid().ToString()

                       }


              ) ;
        }
        private void SeedUserRoles(ModelBuilder builder)
        {
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>()     // 1
                {
                    RoleId = "fa1774c4-5abd-48e9-a18c-0ffa7a83a765",
                    UserId = "591963f3-4778-49c2-a565-32ebe9e4bbe7"
                },
                 new IdentityUserRole<string>()     // 2
                 {
                     RoleId = "c78fb03b-d522-49f9-b80e-45dda9a8fefe",
                     UserId = "07a97ae7-a329-4534-9795-455aaeda7b74"
                 },
                  new IdentityUserRole<string>()     // 3
                  {
                      RoleId = "7f2ac4c5-734f-4490-84a8-9971c21a9132",
                      UserId = "3add81f0-3a56-45ff-adbe-7930786080ef"
                  },
                   new IdentityUserRole<string>()     // 4
                   {
                       RoleId = "5582d545-f8ac-48c2-8c69-927a1124961b",
                       UserId = "cc7e0bf4-b58a-4352-93c9-aca3efbcbd32"
                   },
                    new IdentityUserRole<string>()     // 5
                    {
                        RoleId = "e336c35c-f87c-4f77-a7e0-f4117851e295",
                        UserId = "c2478fca-a65d-4e83-b377-7f5a06a89f19"
                    },
                     new IdentityUserRole<string>()     // 6
                     {
                         RoleId = "08e7e341-61bb-41ec-a419-e2fd8d42c380",
                         UserId = "e5776d2b-d5c6-4afd-968c-280d74a797c0"
                     },
                      new IdentityUserRole<string>()     // 7
                      {
                          RoleId = "773e723b-225f-413d-b534-6b159f718875",
                          UserId = "4502a71c-0341-4d70-a84d-3ba2eee49287"
                      },
                       new IdentityUserRole<string>()     // 8
                       {
                           RoleId = "8de6be3a-dc7a-497a-ae23-4c8acb39adb4",
                           UserId = "849e3092-76eb-4ad3-a41c-1a6236543ba2"
                       }
            );
        }

        public  DbSet<Book> Books { get; set; }
        public  DbSet<Student> Students { get; set; }
        public  DbSet<Author> Authors { get; set; }
        public  DbSet<BookAuthor> BookAuthors { get; set; }

    }
}
