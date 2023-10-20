using IRDbAPI.Database;
using IRDbAPI.Models;
using System;

namespace IRDbAPI.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly AppDbContext _context;
        public MovieRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<MovieModel> GetAllMovies()
        {
            return _context.Movies.ToList();
        }
        public MovieModel? GetMovieById(int Id)
        {
            return _context.Movies.FirstOrDefault(m => m.Id == Id);
        }

        public void AddMovie(MovieModel movie)
        {
            _context.Movies.Add(movie);
            _context.SaveChanges();
        }
        
        public void UpdateMovie(int id, MovieModel movie)
        {
            var existingMovie = _context.Movies.Find(movie.Id);
            if (existingMovie != null)
            {
                existingMovie.Title = movie.Title;
                existingMovie.Director = movie.Director;
                existingMovie.Year = movie.Year;
                existingMovie.Duration = movie.Duration;
                existingMovie.Rating = movie.Rating;

                _context.SaveChanges();
            }

        }
        public void DeleteMovie(int id)
        {
            var movie = _context.Movies.FirstOrDefault(m => m.Id == id);
            if (movie != null)
            {
                _context.Movies.Remove(movie);
                _context.SaveChanges();
            }
        }
    }
}

