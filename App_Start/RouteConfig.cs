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

            //attribute routing

            routes.MapMvcAttributeRoutes();
            //Custom Route               //order of Routes Matters you need to define them from mose specific to generic

           /* routes.MapRoute(
                "MoviesByReleaseDate",  //Route name
                "movies/released/{year}/{month}",    //url pattern parameter
                new {controller = "Movies", action = "ByReleaseDate"},  //3rd argument specify the default
                new {year = @"\d{4}", month = @"\d{2}" }        //ex:  movies/released/2015/04            //constraints for year and month format in the url
                );*/
            //Generic
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
