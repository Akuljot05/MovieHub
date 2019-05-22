using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieHub.Models;
using MovieHub.ViewModels;

namespace MovieHub.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Index()
        {
            var movies = GetMovies();
            return View(movies);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                 new Movie { Id = 1, Name = "Shrek!" },
                 new Movie { Id = 1, Name = "Wall-e" }
            };
           
        }


        
    }
}