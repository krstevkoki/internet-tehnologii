using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace AudMVC1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            routes.MapRoute(
                name: "ShowClient",
                url: "Movies/ShowClient/{id}",
                defaults: new {controller = "Movies", action = "ShowClient", id = 0}
            );

            routes.MapRoute(
                name: "MoviesDefault",
                url: "Movies/{action}",
                defaults: new {controller = "Movies", action = "Random"}
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new {controller = "Home", action = "Index", id = UrlParameter.Optional}
            );
        }
    }
}