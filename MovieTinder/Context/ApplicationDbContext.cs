using Microsoft.EntityFrameworkCore;
using MovieTinder.Models;

namespace MovieTinder.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<MovieModel> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MovieModel>().HasData(
                new MovieModel { Id = 1, Title = "The Nightmare Before Christmas", Description = "Jack Skellington, king of Halloween Town, discovers Christmas Town, but his attempts to bring Christmas to his home causes confusion."},
                new MovieModel { Id = 2, Title = "28 Days Later", Description = "Four weeks after a mysterious, incurable virus spreads throughout the UK, a handful of survivors try to find sanctuary."},
                new MovieModel { Id = 3, Title = "P.S. I Love You", Description = "A young widow discovers that her late husband has left her 10 messages intended to help ease her pain and start a new life."});
        }
    }
}
