using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Aud3MVC.Models;
using Aud3MVC.ViewModels;

namespace Aud3MVC.Controllers
{
    public class ClientsController : Controller
    {
        private MyDbContext _context;

        public ClientsController()
        {
            _context = new MyDbContext();
        }

        public ActionResult ShowClient(int id)
        {
            var model = _context.Clients.Find(id);
            if (model == null)
                return HttpNotFound();
            return View(model);
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
            {
                return View("NewClient", model);
            }
            _context.Clients.Add(model);
            _context.SaveChanges();
            return RedirectToAction("GetAllMovies", "Movies");
        }

        public ActionResult InsertClientInMovie(int id)
        {
            var model = new ClientMovieViewModel()
            {
                Movie = _context.Movies.Find(id),
                MovieId = id,
                Clients = _context.Clients.ToList()
            };
            return View(model);
        }

        [HttpPost]
        public ActionResult InsertClientInMovie(ClientMovieViewModel model)
        {
            var movie = _context.Movies.Find(model.MovieId);
            var client = _context.Clients.Find(model.SelectedClientId);
            if (movie == null || client == null)
                return HttpNotFound();

            movie.Clients.Add(client);
            _context.SaveChanges();
            return RedirectToAction("ShowMovie", "Movies", new {id = movie.Id});
        }
    }
}