using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vanilla_Vivo.Models;

namespace Vanilla_Vivo.Controllers
{
	public class MoviesController : Controller
	{
		//
		// GET: /Movies/
		public ActionResult Random()
		{
            var movie = new Movie()
            {
                Name = "Sherk!"
            };
			return View(movie);
		}
	}
}