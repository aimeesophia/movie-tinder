using System;
using System.Linq;
using MovieTinder.Context;
using MovieTinder.Interfaces;
using MovieTinder.ViewModels;

namespace MovieTinder.ModelBuilders
{
    public class MovieViewModelBuilder : IMovieViewModelBuilder
    {
        private readonly ApplicationDbContext _dbContext;

        public MovieViewModelBuilder(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public MovieViewModel Build()
        {
            var movie = _dbContext.Movies.OrderBy(m => Guid.NewGuid()).FirstOrDefault();

            return new MovieViewModel
            {
                Title = movie.Title,
                Description = movie.Description
            };
        }
    }
}
