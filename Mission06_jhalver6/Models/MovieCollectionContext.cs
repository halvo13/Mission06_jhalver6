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
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {

            mb.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Adventure" },
                new Category { CategoryId = 2, CategoryName = "Romantic Comedy"},
                new Category { CategoryId = 3, CategoryName = "Action" },
                new Category { CategoryId = 4, CategoryName = "Comedy" }
                );

            mb.Entity<AddMovie>().HasData(
                
                new AddMovie
                {
                    MovieId = 1,
                    CategoryId = 1,
                    Title = "The Count of Monte Cristo",
                    Year = 2002,
                    Director = "Kevin Reynolds",
                    Rating = "PG-13",
                    Edited = false
                },
                new AddMovie
                {
                    MovieId = 2,
                    CategoryId = 2,
                    Title = "Hitch",
                    Year = 2005,
                    Director = "Andy Tennant",
                    Rating = "PG-13",
                    Edited = false
                },
                new AddMovie
                {
                MovieId = 3,
                    CategoryId = 3,
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
