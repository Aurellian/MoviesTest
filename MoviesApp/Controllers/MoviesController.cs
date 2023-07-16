using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoviesApp.Data;
using MoviesApp.Models;

namespace MoviesApp.Controllers
{
    public class MoviesController : Controller
    {
        private readonly ApplicationDBContext _dbContext;

        public MoviesController(ApplicationDBContext dBContext)
        {
            _dbContext = dBContext;
        }
        // GET: MoiesController
        public ActionResult Index(string search)
        {
            List<Movie> movies = new List<Movie>();

            if (search != null)
            {
                movies = _dbContext.GetMoviesByTitle(search);
              
            }
            else
            {
                movies = _dbContext.GetAllMovies();
            }
            
            return View(movies);
        }

        // GET: MoiesController/Details/5
        public ActionResult Details(int id)
        {
            var movie = _dbContext.GetMovieById(id);
            return View(movie);
        }

        // GET: MoiesController/Create
        public ActionResult Create()
        {
            
            return View();
        }

        // POST: MoiesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(string title, string producer, DateTime releaseDate, string description, string genre)
        {
            Movie movie = new Movie(title, description, genre, producer, releaseDate);
            _dbContext.Movies.Add(movie);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: MoiesController/Edit/5
        public ActionResult Edit(int id)
        {
            var movie = _dbContext.GetMovieById(id);

            return View(movie);
        }

        // POST: MoiesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, string title, string description, DateTime releaseDate, string genre, string producer)
        {
            var movie = _dbContext.GetMovieById(id);
            movie.UpdateProducer(producer);
            movie.UpdateReleaseDate(releaseDate);
            movie.UpdateDescription(description);
            movie.UpdateTitle(title);
            movie.UpdateGenre(genre);
            _dbContext.SaveChanges();

            return RedirectToAction("Index");
        }

        // GET: MoiesController/Delete/5
        public ActionResult Delete(int id)
        {
            var movie = _dbContext.GetMovieById(id);

            return View(movie);
        }

        // POST: MoiesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            var movie = _dbContext.GetMovieById(id);
            _dbContext.Movies.Remove(movie);
            _dbContext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
