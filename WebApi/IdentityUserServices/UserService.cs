using Microsoft.EntityFrameworkCore;
using WebApi.Data;
using WebApi.Models;

namespace WebApi.IdentityUserServices
{
    public class UserService : IUserService
    {
        private readonly ApplicationContext _context;

        public UserService(ApplicationContext applicationContext)
        {
                _context = applicationContext;
        }
        public Task<string> DeleteById(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUserAsync(Guid Id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<User>> GetUsersAsync()
        {
            return await  _context.Users.ToListAsync();
        }

        public Task<string> Insert(User entry)
        {
            throw new NotImplementedException();
        }

        public Task<string> Update(User entry)
        {
            throw new NotImplementedException();
        }
    }
}
