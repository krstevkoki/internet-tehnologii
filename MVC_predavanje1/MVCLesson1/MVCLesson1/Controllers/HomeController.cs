using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCLesson1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult MyAction()
        {
            return View();
            // return HttpNotFound()
        }

        public ActionResult ContentAction() // no need for a view, returns user content and displays as a plain text  
        {
            return Content("Hello, world from ContentResult");
//            return new EmptyResult();
        }

        public RedirectToRouteResult GoToIndex()
        {
            return RedirectToAction("Index", "Home");
//            return RedirectToAction("Index", "Home", new {page = 1, sortBy = "name"});
        }

        public ContentResult ActionParameter(int id)
        {
            return Content($"id = {id}");
        }

        public ContentResult ByReleaseDate(int year, int month)
        {
            return Content($"{year}/{month}");
        }
    }
}