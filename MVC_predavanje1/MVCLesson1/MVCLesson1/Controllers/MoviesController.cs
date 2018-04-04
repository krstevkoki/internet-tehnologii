using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCLesson1.Models;

namespace MVCLesson1.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ShowMovie()
        {
            Movie model = new Movie
            {
                Name = "Shrek!",
                Rating = 6.76M,
                DownloadURL = @"https://www.yts.am",
                ImageURL = @"https://www.google.com/search?q=Shrek"
            };
            return View(model);
        }
    }
}