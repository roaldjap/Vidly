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
    }
}