using Microsoft.EntityFrameworkCore;
using MovieManagement.Domain.Entities;

namespace MovieManagement.DataAccess
{
    public static class ModelBuilderExtension
    {
        public static void SeedActorData(this ModelBuilder modelBuilder)
        {
            Actor a1 = new Actor() { Id = 1, FirstName = "Brad", LastName = "Pitt" };
            Actor a2 = new Actor() { Id = 2, FirstName = "Angelina", LastName = "Jolie" };
            Actor a3 = new Actor() { Id = 3, FirstName = "Gerard", LastName = "jugnot" };

            modelBuilder.Entity<Actor>().HasData(a1, a2, a3);
        }
        public static void SeedMovieData(this ModelBuilder modelBuilder)
        {
            Movie a1 = new Movie() { Id = 1, Name = "Wakanda Forever", Description = "box office", ActorId = 1 };
            Movie a2 = new Movie() { Id = 2, Name = "Matrix", Description = "in the matrix", ActorId = 2 };
            Movie a3 = new Movie() { Id = 3, Name = "Spiderman", Description = "jumping over skyscrapers", ActorId = 3 };

            modelBuilder.Entity<Actor>().HasData(a1, a2, a3);
        }
    }
}
