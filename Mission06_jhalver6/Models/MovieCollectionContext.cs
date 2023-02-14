using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_jhalver6.Models
{
    public class MovieCollectionContext : DbContext
    {
        //Constructor
        public MovieCollectionContext(DbContextOptions<MovieCollectionContext> options) : base(options)
        {

        }
        public DbSet<AddMovie> Movie { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<AddMovie>().HasData(
                
                new AddMovie
                {
                    Movieid = 1,
                    Category = "Adventure",
                    Title = "The Count of Monte Cristo",
                    Year = 2002,
                    Director = "Kevin Reynolds",
                    Rating = "PG-13",
                    Edited = false
                },
                new AddMovie
                {
                    Movieid = 2,
                    Category = "Romantic Comedy",
                    Title = "Hitch",
                    Year = 2005,
                    Director = "Andy Tennant",
                    Rating = "PG-13",
                    Edited = false
                },
                new AddMovie
                {
                Movieid = 3,
                    Category = "Action",
                    Title = "The Dark Knight",
                    Year = 2008,
                    Director = "Christopher Nolan",
                    Rating = "PG-13",
                    Edited = false
                }
                );
        }
    }
}
