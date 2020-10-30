using Microsoft.AspNetCore.Mvc;
using MovieTinder.Context;
using MovieTinder.Interfaces;

namespace MovieTinder.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMovieViewModelBuilder _movieViewModelBuilder;

        public HomeController(IMovieViewModelBuilder movieViewModelBuilder)
        {
            _movieViewModelBuilder = movieViewModelBuilder;
        }

        public IActionResult Index()
        {
            var movieViewModel = _movieViewModelBuilder.Build();

            return View(movieViewModel);
        }
    }
}
