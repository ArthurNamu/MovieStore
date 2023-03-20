using CleanMovie.Application;
using CleanMovie.Infrastructure.Data;
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

        private readonly MovieDbContext _context;

        public MovieRepository(MovieDbContext movieDbContext)
        {
            _context = movieDbContext;
        }
        public Movie CreateMovie(Movie newMovie)
        {
           _context.Movies.Add(newMovie);
            _context.SaveChanges();

            return newMovie;
        }

        public List<Movie> GetAllMovies()
        {
            return  _context.Movies.ToList();
        }

        public Movie GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
