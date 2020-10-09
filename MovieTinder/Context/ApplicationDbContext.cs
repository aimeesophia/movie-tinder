using Microsoft.EntityFrameworkCore;
using MovieTinder.Models;

namespace MovieTinder.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(
                new Movie() { Id = 1, Title = "Nightmare Before Christmas" },
                new Movie() { Id = 2, Title = "28 Days Later" },
                new Movie() { Id = 3, Title = "P.S. I Love You" });
        }
    }
}
