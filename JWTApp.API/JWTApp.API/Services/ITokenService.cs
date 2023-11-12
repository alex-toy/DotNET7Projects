using JWTApp.API.Dtos;
using System.IdentityModel.Tokens.Jwt;

namespace JWTApp.API.Services
{
    public interface ITokenService
    {
        JwtSecurityToken GenerateToken(LoginDto login);
        string GenerateTokenHandler(LoginDto login);
    }
}