using JWTApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace JWTApp.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            User[] users = new[] { new User() { Id = 1, UserName = "admin", Password = "Pa$$w0rd" } };
            modelBuilder.Entity<User>().HasData(users);   
        }
    }
}
