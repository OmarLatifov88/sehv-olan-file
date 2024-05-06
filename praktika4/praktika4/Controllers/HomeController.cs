using Microsoft.AspNetCore.Mvc;
using praktika4.Contexts;

namespace praktika4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProniaDbContext _DbContext;

        public HomeController(ProniaDbContext dbContext)
        {
            _DbContext = dbContext;
        }

        public IActionResult Index()
        {
            var sliders = _DbContext.Sliders.ToList();

            return View(sliders);
        }
    }
}
