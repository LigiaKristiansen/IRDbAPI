using IRDbAPI.Models;

namespace IRDbAPI.Repositories
{
    public interface IMovieRepository
    {
        public IEnumerable<MovieModel> GetAllMovies();
        public MovieModel? GetMovieById(int Id);
        public void AddMovie(MovieModel movie);
        public void UpdateMovie(int id, MovieModel movie);
        public void DeleteMovie(int id);
    }
}