using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using WebApi.Data;
using WebApi.Models;

namespace WebApi.ConfigurationServices.IdentityConfigurationServices
{
    public class UserRoleConfigurationService
    {
        //        private static readonly UserManager<User> _userManager;
        //        private static readonly AspNetRoleManager<IdentityRole> _roleManager;
        //        public UserRoleConfigurationService(UserManager<User> userManager)
        //        {
        //          //  _userManager = userManager;
        //        }

        //        public static async Task<IdentityResult> Initialize(ApplicationContext context)
        //        {
        //            var context = serviceProvider.GetService<ApplicationContext>();

        //            string[] roles = new string[] { "Owner", "Administrator", "Manager", "Editor", "Buyer", "Business", "Seller", "Subscriber" };
        //            string[] roles = new string[] { "Owner", "Administrator", "Manager", "Editor", "Buyer", "Business", "Seller", "Subscriber" };

        //            foreach (string role in roles)
        //            {
        //                var roleStore = new RoleStore<IdentityRole>(context);

        //                if (!context.Roles.Any(r => r.Name == role))
        //                {
        //                    await roleStore.CreateAsync(new IdentityRole(role));
        //                    var roles = await _roleManager.FindByNameAsync();
        //                }
        //            }


        //            var user = new User
        //            {
        //                FirstName = "Akmal",
        //                LastName = "Akmalov",
        //                Email = "akmal@mail.com",
        //                NormalizedEmail = "AKMAL@MAIL.COM",
        //                UserName = "Administrator",
        //                NormalizedUserName = "ADMINISTRATOR",
        //                PhoneNumber = "+992911288822",
        //                EmailConfirmed = true,
        //                PhoneNumberConfirmed = true,
        //                SecurityStamp = Guid.NewGuid().ToString()
        //            };


        //            if (!context.Users.Any(u => u.UserName == user.UserName))
        //            {
        //                var password = new PasswordHasher<User>();
        //                var hashed = password.HashPassword(user, "12345");
        //                user.PasswordHash = hashed;

        //                var userStore = new UserStore<User>(context);
        //                var result1 = userStore.CreateAsync(user);
        //                await context.SaveChangesAsync();

        //            }

        //            var users = await _userManager.FindByNameAsync(user.UserName);
        //            var result = await _userManager.AddToRolesAsync(users, roles);
        //             await context.SaveChangesAsync();
        //            if (result.Succeeded)
        //            {
        //                return IdentityResult.Success;
        //            }
        //            return IdentityResult.Failed();


        //            await context.SaveChangesAsync();
        //        }

        //        //public static async Task<IdentityResult> AssignRoles(/*IServiceProvider services, */string username, string[] roles)
        //        //{

        //        //    var _userManager = services.GetService<UserManager<User>>();
        //        //    var user = await _userManager.FindByNameAsync(username);
        //        //    var result = await _userManager.AddToRolesAsync(user, roles);
        //        //    if (result.Succeeded)
        //        //    {
        //        //        return IdentityResult.Success;
        //        //    }
        //        //    return IdentityResult.Failed();



        //        //}
    }
}
