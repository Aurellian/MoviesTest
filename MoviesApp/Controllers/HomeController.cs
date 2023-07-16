using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MoviesApp.Data;
using MoviesApp.Models;

namespace MoviesApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly ApplicationDBContext _dbContext;

        public HomeController(ApplicationDBContext dBContext)
        {
            _dbContext = dBContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}