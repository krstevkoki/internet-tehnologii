using Aud3MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Aud3MVC.ViewModels;

namespace Aud3MVC.Controllers
{
    public class MoviesController : Controller
    {
        private static List<Movie> movies = new List<Movie>()
        {
            new Movie()
            {
                Name = "Shrek!",
                Rating = 6.7M,
                DownloadURL = @"https://www.google.com/search?q=Shrek!",
                ImageURL =
                    @"https://vignette.wikia.nocookie.net/shrek/images/9/9b/GoodShrekImage.png/revision/latest?cb=20171217221732"
            }
        };

        private static List<Client> clients = new List<Client>()
        {
        };

        // GET: Movies
        public ActionResult GetAllMovies()
        {
            return View(movies);
        }

        public ActionResult ShowClient(int id)
        {
            if (id >= 0 && id < clients.Count)
            {
                Client model = clients[id];
                return View(model);
            }

            return HttpNotFound();
        }

        public ActionResult NewClient()
        {
            Client model = new Client();
            return View(model);
        }

        [HttpPost]
        public ActionResult NewClient(Client model)
        {
            if (!ModelState.IsValid)
                return View("NewClient", model);
            clients.Add(model);
            return RedirectToAction("GetAllMovies", "Movies");
        }

        public ActionResult ShowMovie(int id)
        {
            MovieRentalViewModel model = new MovieRentalViewModel()
            {
                Movie = movies.ElementAt(id),
                Clients = clients
            };
            return View(model);
        }

        public ActionResult EditMovie(int id)
        {
            var model = movies.ElementAt(id);
            model.ID = id;
            return View(model);
        }

        [HttpPost]
        public ActionResult EditMovie(Movie model)
        {
            if (!ModelState.IsValid)
                return View("EditMovie", model);
            movies.RemoveAt(model.ID);
            movies.Insert(model.ID, model);
            return RedirectToAction("GetAllMovies", "Movies");
//            return View("GetAllMovies", movies);
        }

        public ActionResult NewMovie()
        {
            Movie model = new Movie();
            return View(model);
        }

        [HttpPost]
        public ActionResult NewMovie(Movie model)
        {
            if (!ModelState.IsValid)
                return View("NewMovie", model);
            movies.Add(model);
            return RedirectToAction("GetAllMovies", "Movies");
//            return View("GetAllMovies", movies);
        }

        public ActionResult DeleteMovie(int id)
        {
            movies.RemoveAt(id);
            return RedirectToAction("GetAllMovies", "Movies");
//            return View("GetAllMovies", movies);
        }
    }
}