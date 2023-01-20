using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace RentVids
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            /*Routes should be configure from the more specific on top to less specific*/
            //routes.MapRoute(
            //    name: "MoviesByReleaseDate",
            //    url: "Movie/Released/{year}/{month}",
            //    defaults: new { controller = "Movie", action = "ByReleaseDate" },
            //    new {year = @"\d{4}", month = @"\d{2}"}
            //    //new{year = @"2015|2016"}
            //); Another way to costum is to add a decoration to Controller action []
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
