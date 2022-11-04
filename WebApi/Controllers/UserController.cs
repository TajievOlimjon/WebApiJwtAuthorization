using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.IdentityUserServices;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService )
        {
            _userService = userService;
        }
        [HttpGet("Users")]
        public async Task<IActionResult> GetUserAsync()
        {
            var users=await _userService.GetUsersAsync();
            return Ok(users);
        }
    }
}
