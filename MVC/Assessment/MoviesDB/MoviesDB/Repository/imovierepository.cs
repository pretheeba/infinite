using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoviesDB.Models;

namespace MoviesDB.Repository
{
    public interface imovierepository : IDisposable
    {
        IEnumerable<Movie> GetAllMovies();
        Movie GetMovieById(int id);
        void InsertMovie(Movie movie);
        void UpdateMovie(Movie movie);
        void DeleteMovie(int id);
        void Save();
    }
}
