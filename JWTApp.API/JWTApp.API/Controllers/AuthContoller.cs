using JWTApp.API.Data;
using JWTApp.API.Dtos;
using JWTApp.API.Models;
using JWTApp.API.Services;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;

namespace JWTApp.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthContoller : ControllerBase
    {
        private readonly AppDbContext _appDbContext;
        private readonly ITokenService _token;

        public AuthContoller(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginDto login)
        {
            if (ModelState.IsValid) return BadRequest(ModelState);

            User user = _appDbContext.Users.FirstOrDefault(u => u.UserName == login.UserName && u.Password == login.Password);
            if (user == null) return Unauthorized();

            JwtSecurityToken token = _token.GenerateToken(login);

            string tokenHandler = _token.GenerateTokenHandler(login);

            return Ok(tokenHandler);
        }
    }
}
