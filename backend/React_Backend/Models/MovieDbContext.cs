using Microsoft.EntityFrameworkCore;

namespace React_Backend.Models
{
    public class MovieDbContext : DbContext
    {
        public MovieDbContext(DbContextOptions<MovieDbContext> options) : base(options)
        {
        }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
            new Category { CategoryId = 1, CategoryName = "Science Fiction" },
            new Category { CategoryId = 2, CategoryName = "Action" },
            new Category { CategoryId = 3, CategoryName = "Drama" },
            new Category { CategoryId = 4, CategoryName = "Romance" },
            new Category { CategoryId = 5, CategoryName = "Comedy" },
            new Category { CategoryId = 6, CategoryName = "Documentary" },
            new Category { CategoryId = 7, CategoryName = "Horror" },
            new Category { CategoryId = 8, CategoryName = "Thriller" },
            new Category { CategoryId = 9, CategoryName = "Adventure" }
            );
        }

    }
}
