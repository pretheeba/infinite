using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MoviesDB.Models
{
    public class MoviesDbContext : DbContext
    {
        public MoviesDbContext() : base("connection")
        {

        }
        public DbSet<Movie> Movies { get; set; }
    }
}