using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

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
            return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name"});
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

        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content( year + "/" + month);
        }

        
    }
}