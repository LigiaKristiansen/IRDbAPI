using IRDbAPI.Models;
using IRDbAPI.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace IRDbAPI.Controllers

{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieRepository _movieRepository;

        public MoviesController(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        [HttpGet]
        public IEnumerable<MovieModel> GetAllMovies()
        {
            return _movieRepository.GetAllMovies();
        }

        [HttpGet("{id}")]
        public MovieModel GetMovieById(int id)
        {
            return _movieRepository.GetMovieById(id);
        }

        [HttpPost]
        public void AddMovie(MovieModel movie)
        {
            _movieRepository.AddMovie(movie);
        }

        [HttpPut("{id}")]
        public void UpdateMovie(int id, MovieModel movie)
        {
            _movieRepository.UpdateMovie(id, movie);
        }

        [HttpDelete("{id}")]
        public void DeleteMovie(int id)
        {
            _movieRepository.DeleteMovie(id);
        }
    }
}

