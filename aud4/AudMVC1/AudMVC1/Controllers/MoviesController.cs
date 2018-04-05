using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AudMVC1.Models;

namespace AudMVC1.Controllers
{
    public class MoviesController : Controller
    {
        private Movie movie = new Movie()
        {
            Name = "Shrek!",
            Rating = 6.7M,
            DownloadURL = @"https://www.google.com/search?q=Shrek!",
            ImageURL =
                @"https://vignette.wikia.nocookie.net/shrek/images/9/9b/GoodShrekImage.png/revision/latest?cb=20171217221732"
        };

        private static List<Client> clients = new List<Client>()
        {
            new Client()
            {
                Name = "Kostadin Krstev",
                Age = 19,
                Address = "Dame Gruev 47",
                Telephone = "+389 72 256 652",
                MemberCard = "A1000"
            },
            new Client()
            {
                Name = "Petko Petkov",
                Age = 15,
                Address = "Pitu Guli 63",
                Telephone = "+389 75 254 123",
                MemberCard = "A1001"
            },
            new Client()
            {
                Name = "Trajko Trajkov",
                Age = 25,
                Address = "Ilindenska 47",
                Telephone = "+389 76 787 889",
                MemberCard = "A1002"
            }
        };

        // GET: Movies
        public ActionResult Random()
        {
            MovieRental model = new MovieRental(movie, clients);
            /*MovieRental model = new MovieRental()
            {
                Movie =  movie,
                Clients = clients
            };*/
//            model.Movie = movie;
//            model.Clients = clients;
            return View(model);
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
    }
}