using CleanMovie.Application;
using CleanMovieDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMovie.Infrastructure
{
    public class MovieRepository : IMovieRepository
    {
        public static List<Movie> movies = new List<Movie>()
        {
            new Movie{Id = 1, Name = "Passion Of Christ"},
            new Movie{Id = 2, Name = "Home Alone"},
        };

        public Movie CreateMovie(Movie newMovie)
        {
            throw new NotImplementedException();
        }

        public List<Movie> GetAllMovies()
        {
            return  movies;
        }

        public Movie GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
