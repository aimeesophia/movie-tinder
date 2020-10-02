using Microsoft.AspNetCore.Mvc;

namespace MovieTinder.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
