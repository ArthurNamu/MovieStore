using CleanMovieDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMovie.Application
{
    public interface IMovieService
    {
        List<Movie> GetAllMovies();

        Movie GetMovie(int id);
        Movie CreateMovie(Movie newMovie);
    }
}
