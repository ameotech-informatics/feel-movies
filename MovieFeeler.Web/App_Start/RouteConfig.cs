using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MovieFeeler.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Bollywood", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
               name: "toprated",
               url: "{controller}/{action}/{page}",
               defaults: new { controller = "Movie", action = "TopRated", page = UrlParameter.Optional }
           );



            routes.MapRoute(
                name: "PageRoute",
                url: "{controller}/{action}/{id}/{name}/{page}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional, name = UrlParameter.Optional, page = UrlParameter.Optional }
            );
            
            routes.MapRoute(
               name: "Search",
               url: "{controller}/{action}/{q}/{page}",
               defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional,q=UrlParameter.Optional, page = UrlParameter.Optional }
           );
        }
    }
}