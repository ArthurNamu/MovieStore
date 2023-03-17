using CleanMovieDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMovie.Application
{
    public interface IMovieRepository
    {
        List<Movie> GetAllMovies();
        Movie GetById(int id);
        Movie CreateMovie(Movie newMovie);
    }
}
