using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCAud4.Models;
using MVCAud4.ViewModels;

namespace MVCAud4.Controllers
{
    public class MoviesController : Controller
    {
        private MyDbContext _context;

        public MoviesController()
        {
            _context = new MyDbContext();
        }

        // GET: Movies
        public ActionResult GetAllMovies()
        {
            var model = _context.Movies.ToList();
//            model.Sort((movie1, movie2) => movie1.Name.CompareTo(movie2.Name));
            return View(model);
        }

        public ActionResult ShowMovie(int id)
        {
//            var movie = _context.Movies.FirstOrDefault(_movie => _movie.Id == id);
            var movie = _context.Movies.Find(id);
            if (movie == null)
                return HttpNotFound();
            var clients = movie.Clients.ToList();
//            clients.Sort((client1, client2) => client2.Age.CompareTo(client1.Age));
            MovieRentalViewModel model = new MovieRentalViewModel()
            {
                Movie = movie,
                Clients = clients
            };
            return View(model);
        }

        public ActionResult EditMovie(int id)
        {
            var model = _context.Movies.Find(id);
            if (model == null)
                return HttpNotFound();
            //model.Id = id;
            return View(model);
        }

        [HttpPost]
        public ActionResult EditMovie(Movie model)
        {
            if (!ModelState.IsValid)
                return View("EditMovie", model);
            var toEdit = _context.Movies.Find(model.Id);
            if (toEdit == null)
                return HttpNotFound();

            toEdit.DownloadURL = model.DownloadURL;
            toEdit.ImageUrl = model.ImageUrl;
            toEdit.Name = model.Name;
            toEdit.Rating = model.Rating;

            _context.SaveChanges();
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
            _context.Movies.Add(model);
            _context.SaveChanges();
            return RedirectToAction("GetAllMovies", "Movies");
//            return View("GetAllMovies", movies);
        }

        public ActionResult DeleteMovie(int id)
        {
            var movie = _context.Movies.Find(id);
            if (movie != null)
            {
                _context.Movies.Remove(movie);
                _context.SaveChanges();
            }

            return RedirectToAction("GetAllMovies", "Movies");
//            return View("GetAllMovies", movies);
        }
    }
}