namespace MovieManagement.Domain.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        IActorRepository ActorRepository { get; }
        IMovieRepository MovieRepository { get; }
        IGenreRepository GenreRepository { get; }
        IBiographyRepository BiographyRepository { get; }
        int save();
    }
}
