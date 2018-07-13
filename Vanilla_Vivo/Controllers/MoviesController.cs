using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vanilla_Vivo.Models;
using Vanilla_Vivo.ViewModels;

namespace Vanilla_Vivo.Controllers
{
	public class MoviesController : Controller
	{
		//
		// GET: /Movies/

        public ActionResult Index()
        {
            var movie = GetMovies();

            return View(movie);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie{ Id = 1 , Name = "Sherk"},
                new Movie{ Id = 2 , Name = "Walle"}
            };
        }
        
        /* public ActionResult Random()
        {
           
            var movie = new Movie() 
            {
                Name = "Sherk!"
            };

            var customers = new List<Customer>
            {
               new Customer{Name = "Customer 1"},
               new Customer {Name = "Customer 2"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };
            
            //ViewBag.movieName = movie;


            return View(viewModel);
            
        }
        */


		/*public ActionResult Random()
		{
            var movie = new Movie()
            {
                Name = "Sherk!"
            };
            //return View(movie);
            //return Content("Hello World");
            //return HttpNotFound();
            //return new EmptyResult();

            return RedirectToAction("Index", "Home", new {page = 1,sortBy = "name"});
        }
        */
        //public ActionResult Edit(int id)
        //{
        //    return Content("id = " + id);
        //}

        //public ActionResult Index(int? pageIndex,string sortBy)
        //{
        //    if (!pageIndex.HasValue)
        //        pageIndex = 1;
        //    if (String.IsNullOrWhiteSpace(sortBy))
        //        sortBy = "name";

        //    return Content(String.Format("PageIndex = {0} & SortBy = {1}",pageIndex,sortBy));
        //}

        /*useing attribute route
        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year,int month)
        {

            return Content(year + "/" + month);
        }
        */
	}
}