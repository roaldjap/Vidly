using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private MyDBContext _context;
        public MoviesController()
        {
            _context = new MyDBContext();
        }
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            // NOTE: usually used ActionResult helpers
            //return View(movie);
            //return HttpNotFound();
            //return Redirect(); // RedirectResult

            //for debugging
            //return Content("Hello World");
            //return new EmptyResult();

            // redirect and pass arguments to next page: $page = 1 and sortBy = "name"
            //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name"});

            //var ViewModel = new RandomMovieViewModel
            //{
            //    Movie = movie,
            //    Customers = customers
            //};

            //return View(ViewModel);
            return new EmptyResult();
        }

  

        public ActionResult Index() {
            var movies = _context.Movies.Include( m => m.Genre).ToList();

            return View(movies);
        }

        public ActionResult Details(int id)
        {
            var movie = _context.Movies.Include( m => m.Genre ).SingleOrDefault(movieItem => movieItem.Id == id);
            return View(movie);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie { Id = 1, Name = "Frozen II" },
                new Movie { Id = 2, Name = "Rubik's Cube" },
                new Movie { Id = 3, Name = "Iron Man"}

            };
        }



    }
}