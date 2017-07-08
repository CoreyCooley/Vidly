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
            var customers = new List<Customer>
            {
                new Customer {Name = "Corey"},
                new Customer {Name = "Brittany"}
            };

            var viewModel = new RandomMovieViewModel()
            {
                Movie = movie,
                Customers = customers
            };

            // You can pass data to the views Don't do the two below
            // ViewData["Movie"] = movie;
            // No Compile Time Check
            //ViewBag.Movie = movie;
            // return View();

            // Helper Method Inherited from the Base Class Controller
            // return View(movie);
            return View(viewModel);

            // Other ActionResults:
            // return Content("Hello World!");
            // return HttpNotFound();
            // return new EmptyResult();
            // return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name"});
        }

        // Get: Movies/Edit/id
        public ActionResult Edit(int id)
        {
            return Content("Id = " + id);

        }

        // Get: Movies/Index/
        // int? == the int par is optional
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if(!pageIndex.HasValue)
            {
                pageIndex = 1;
            }
            if (String.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name";
            }

            return Content(String.Format("pageIndex=={0} and sortBy={1}", pageIndex, sortBy));
        }

        // Use Attribute Routes for Custome Routing
        [Route("movies/released/{year:regex(\\d{4})}/{month:regex(\\d{2}):range(1,12)}")]
        // Get: Movies/Release/Year/Month
        public ActionResult ByReleaseDate(int year, int month)
        {

            return Content(year + "/" + month);
        }

    }
}