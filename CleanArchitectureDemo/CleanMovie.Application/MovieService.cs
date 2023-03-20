using CleanMovieDomain;

namespace CleanMovie.Application;

public class MovieService : IMovieService
{
    private readonly IMovieRepository _movieRepository;

    //Contructor dependecy injection
    public MovieService(IMovieRepository movieRepository)
    {
        _movieRepository = movieRepository;
    }

    public Movie CreateMovie(Movie newMovie)
    {
        _movieRepository.CreateMovie(newMovie);
        return newMovie;
    }

    public List<Movie> GetAllMovies()
    {
        var movies = _movieRepository.GetAllMovies();

        return movies;
    }

    public Movie GetMovie(int id)
    {
        throw new NotImplementedException();
    }
}
