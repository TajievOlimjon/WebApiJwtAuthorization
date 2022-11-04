using WebApi.BaseServices;
using WebApi.Models;

namespace WebApi.IdentityUserServices
{
    public interface IUserService:IBaseService<User>
    {
        Task<List<User>> GetUsersAsync();
        Task<User> GetUserAsync(Guid Id);
    }
}
