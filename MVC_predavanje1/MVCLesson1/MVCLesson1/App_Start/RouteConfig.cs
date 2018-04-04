using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCLesson1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "MoviesByReleaseDate",
                url: "home/released/{year}/{month}",
                defaults: new {controller = "Home", action = "ByReleaseDate"},
                constraints: new {year = @"\d{4}", month = @"\d{1}|\d{2}"}
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new {controller = "Home", action = "Index", id = UrlParameter.Optional}
            );
        }
    }
}