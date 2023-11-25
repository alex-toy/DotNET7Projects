using Microsoft.EntityFrameworkCore;
using MovieManagement.DataAccess.Context;
using MovieManagement.DataAccess.Implementation;
using MovieManagement.Domain.Repository;

namespace MovieManagement.API
{
    public static class WebAppBuilderExtension
    {
        public static void ConfigureDatabase(this WebApplicationBuilder builder)
        {
            builder.Services.AddDbContext<MovieDbContext>(options =>
            {
                string? connectionString = builder.Configuration.GetSection("ConnectionStrings:MovieConnectionString").Value;
                options.UseSqlServer(connectionString);
            });
        }

        public static void ConfigureUnitOfWork(this WebApplicationBuilder builder)
        {
            builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();
        }
    }
}
