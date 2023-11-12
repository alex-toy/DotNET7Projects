using JWTApp.API.Data;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace JWTApp.API
{
    public static class WebAppExtension
    {
        public static void ConfigureDbContext(this WebApplicationBuilder builder)
        {
            string connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
            builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connectionString));
        }

        public static void ConfigureAuthentication(this WebApplicationBuilder builder)
        {
            AuthenticationBuilder authenticationBuilder = builder.Services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            });

            string validIssuer = builder.Configuration["Jwt:Issuer"];
            string validAudience = builder.Configuration["Jwt:Audience"];
            string key = builder.Configuration["Jwt:Key"];
            byte[] jwt_key = Encoding.UTF8.GetBytes(key);
            SymmetricSecurityKey symmetricSecurityKey = new(jwt_key);

            TokenValidationParameters tokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidateLifetime = true,
                ValidateIssuerSigningKey = true,
                ValidIssuer = validIssuer,
                ValidAudience= validAudience,
                IssuerSigningKey = symmetricSecurityKey
            };

            authenticationBuilder.AddJwtBearer(options => {
                options.TokenValidationParameters = tokenValidationParameters;
            });
        }
    }
}
