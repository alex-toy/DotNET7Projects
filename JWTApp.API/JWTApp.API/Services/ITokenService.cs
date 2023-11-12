using JWTApp.API.Dtos;
using System.IdentityModel.Tokens.Jwt;

namespace JWTApp.API.Services
{
    public interface ITokenService
    {
        string GenerateTokenHandler(LoginDto login);
    }
}