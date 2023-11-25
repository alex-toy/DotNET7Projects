using MovieManagement.DataAccess.Context;
using MovieManagement.Domain.Repository;

namespace MovieManagement.DataAccess.Implementation
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MovieDbContext _context;

        public UnitOfWork(MovieDbContext context)
        {
            _context = context;
            ActorRepository = new ActorRepository(context);
            MovieRepository = new MovieRepository(context);
            GenreRepository = new GenreRepository(context);
            BiographyRepository = new BiographyRepository(context);
        }

        public IActorRepository ActorRepository { get; private set; }
        public IMovieRepository MovieRepository { get; private set; }
        public IGenreRepository GenreRepository { get; private set; }
        public IBiographyRepository BiographyRepository { get; private set; }

        public void Dispose()
        {
            _context.Dispose();
        }

        public int save()
        {
            return _context.SaveChanges();
        }
    }
}
