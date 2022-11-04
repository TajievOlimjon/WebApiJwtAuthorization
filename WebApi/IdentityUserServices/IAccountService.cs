using WebApi.Data.Wrapper;
using WebApi.Models;

namespace WebApi.IdentityUserServices
{
    public interface IAccountService
    {  
        ValueTask<Response> Login(LoginDto dto);
        ValueTask<Response> Registration(RegisterDto dto);
    }
}
