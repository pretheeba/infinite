using MoviesDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MoviesDB.Repository
{
    public class movierepository : imovierepository
    {
        private MoviesDbContext context;

        public movierepository(MoviesDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<Movie> GetAllMovies()
        {
            return context.Movies.ToList();
        }

        public Movie GetMovieById(int id)
        {
            return context.Movies.Find(id);
        }

        public void InsertMovie(Movie movie)
        {
            context.Movies.Add(movie);
        }

        public void UpdateMovie(Movie movie)
        {
            context.Entry(movie).State = EntityState.Modified;
        }

        public void DeleteMovie(int id)
        {
            Movie movie = context.Movies.Find(id);
            if (movie != null)
            {
                context.Movies.Remove(movie);
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}