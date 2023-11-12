using JWTApp.API.Dtos;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace JWTApp.API.Services
{
    public class TokenService : ITokenService
    {
        private readonly IConfiguration _config;

        public TokenService(IConfiguration config)
        {
            _config = config;
        }

        private JwtSecurityToken GenerateToken(LoginDto login)
        {
            Claim[] claims = GetClaims(login);

            string issuer = _config["Jwt:Issuer"];
            string audience = _config["Jwt:Audience"];
            string key = _config["Jwt:Key"];
            byte[] jwt_key = Encoding.UTF8.GetBytes(key);
            SymmetricSecurityKey signinKey = new SymmetricSecurityKey(jwt_key);
            DateTime expires = DateTime.Now.AddDays(1);
            SigningCredentials signingCredentials = new SigningCredentials(signinKey, SecurityAlgorithms.HmacSha256);
            JwtSecurityToken token = new JwtSecurityToken(issuer: issuer, audience:audience, claims:claims, expires:expires, signingCredentials:signingCredentials);
            return token;
        }

        private static Claim[] GetClaims(LoginDto login)
        {
            return new[]
            {
                new Claim(JwtRegisteredClaimNames.Name, login.UserName),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            };
        }

        public string GenerateTokenHandler(LoginDto login)
        {
            var token = GenerateToken(login);
            string tokenHandler = new JwtSecurityTokenHandler().WriteToken(token);
            return tokenHandler;
        }
    }
}
