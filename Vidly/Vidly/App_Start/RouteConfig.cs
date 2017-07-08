using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Vidly
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();


            /*
            // Order of Routes matter list from specific to general
            // This is not the best way to do custom routes!! With MVC 5 we can use a attribute routing
            routes.MapRoute(
                name: "MoviesByReleaseDate",
                url: "movies/released/{year}/{month}",
                defaults: new { controller = "Movies", action = "ByReleaseDate"},
                constraints: new { year = @"\d{4}", month = @"\d{2}"}
                //constraints: new { year = @"2015|2016", month = @"\d{2}" } // This allows you to add contraints on the year
            );
            */

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
