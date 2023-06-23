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

        public ViewResult Index()
        {
            var movies = GetMovies();

            return View(movies);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie { Id = 1, Name = "Shrek" },
                new Movie { Id = 2, Name = "Wall-e" }
            };
        }
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            var customers = new List<Customer>
            {
                new Customer { Name = "Customer 1" }, //object initailization syntax to add obejct customer here
                new Customer { Name = "Customer 2" } //object initailization syntax to add obejct customer here
            };

            var viewModel = new RandomMovieViewModel()
            {
                Movie = movie,
                Customers = customers
            };

         /*   ViewData["Movie"] = movie;
            ViewBag.Movie = movie;*/
            return View(viewModel);  //this is better
        }

       /* [Route("movies/released/{year}/{month:regex(\\d{4}):range(1,12)}")] // with month constraints
       public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);

        }*/

        /*public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        //movies
        public ActionResult Index(int? pageIndex, string sortBy) // to make pageIndex parameter it optional make it nullable;
                                                                 // no need for sortBy becasuse string in C# is a ref type and is nullable
        {
            if (!pageIndex.HasValue) //if doesn't have value
                pageIndex = 1;
            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex,sortBy));
        }*/
    }

}