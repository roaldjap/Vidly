using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
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

            var customers = new List<Customer>
            {
                new Customer { Name = "Customer 1" },
                new Customer { Name = "Customer 2" }
            };

            var ViewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(ViewModel);
        }

        public ActionResult Edit(int id){
            return Content("id= " + id);
        }

        public ActionResult Index(int? pageIndex, string sortBy) {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";
            return Content(String.Format("pageIndex={0}&sortBt{1}", pageIndex, sortBy));
        }

        //attritute routing - Google: ASP.NET MVC Attribute Route constraints
        [Route("movies/released/{year}/{month:regex(\\d{4}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content( year + "/" + month);
        }

        
    }
}