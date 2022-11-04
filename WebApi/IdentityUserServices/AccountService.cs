using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using WebApi.Data.Wrapper;
using WebApi.Models;

namespace WebApi.IdentityUserServices
{
    public class AccountService:IAccountService
    {
        private readonly IConfiguration _configuration;
        private readonly UserManager<User> _userManager;

        public AccountService(UserManager<User> userManager,IConfiguration  configuration)
        {
            _userManager = userManager;
            _configuration = configuration;
        }

        public async ValueTask<Response> Login(LoginDto model)
        {
            Response? response = null;
             var   user = await _userManager.FindByNameAsync(model.UserName);

            if(user == null)
            {
                response = new Response
                {
                    StatusCode = System.Net.HttpStatusCode.BadRequest,
                    Message = "Пользователь не найден !!"
                };
                return response;
            }
            if(!user.Equals(null))
            {
                // var result = await _userManager.CheckPasswordAsync(user, model.Password);
                var result = BCrypt.Net.BCrypt.Verify(model.Password, user.PasswordHash);
                if (result.Equals(false) )
                { 
                    response = new Response
                    {
                        StatusCode = System.Net.HttpStatusCode.BadRequest,
                        Message = "Неправильный пароль"
                    };
                    return response;
                }
            }

                response=  await GenerateJwtToken(user);
                return response;
           
        }

        private async Task<Response> GenerateJwtToken(User user)
        {
            

            var roles = await _userManager.GetRolesAsync(user);

            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            var claims = new List<Claim>()
             {    
                  new Claim("Id", Guid.NewGuid().ToString()),
                  new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
                  new Claim(ClaimTypes.Name, user.UserName),
                  new Claim(ClaimTypes.NameIdentifier, user.Id),
                  new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
             };

            //add role
            foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role,role));
            }

            var token = new JwtSecurityToken(
                issuer: _configuration["Jwt:Issuer"],
                audience: _configuration["Jwt:Audience"],
                claims: claims,
                expires: DateTime.UtcNow.AddDays(1),
                signingCredentials: credentials
            );

            return new Response()
            {    Message="Ваш токен",
                 StatusCode=System.Net.HttpStatusCode.OK,
                 Token = new JwtSecurityTokenHandler().WriteToken(token),
            };
        }

        public async ValueTask<Response> Registration(RegisterDto dto)
        {  
            Response? response=null;

            var email = await _userManager.FindByEmailAsync(dto.Email);
            var username = await _userManager.FindByNameAsync(dto.UserName);
          
            if (email != null || username != null)
            {
                    response = new Response { StatusCode = System.Net.HttpStatusCode.Unauthorized,
                    Message = "Пользователь уже существует! Дублирование запрещено ! " };
                return response;
            }

            
            var user = new User()
            {
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Email = dto.Email,
                MiddleName = dto.MiddleName,
                UserName = dto.UserName,
                PhoneNumber = dto.PhoneNumber,
                PasswordHash=BCrypt.Net.BCrypt.HashPassword(dto.Password)
                
            };
            var register = await _userManager.CreateAsync(user);
            if (register.Succeeded)
            {
                  response = new Response
                  {
                      StatusCode = System.Net.HttpStatusCode.Created,
                      Message = "Вы успешно зарегистрировались !"
                  };
            }
            return response;
        }

    }
}
