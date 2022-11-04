using Microsoft.AspNetCore.Mvc;
using WebApi.Data.Wrapper;
using WebApi.IdentityUserServices;
using WebApi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _service;

        public AccountController(IAccountService service)
        {
            _service = service;
        }

        [HttpPost("Login")]
      public async ValueTask<Response> Login(LoginDto loginDto)
        {
            return  await _service.Login(loginDto);
        }
        [HttpPost("Registration")]
        public async ValueTask<Response> Registration(RegisterDto registerDto)
        {
            return await _service.Registration(registerDto);
        }


    }
}
