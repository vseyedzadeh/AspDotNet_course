using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace VidPlace
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
               name: "Default-test",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Test", action = "getString", id = UrlParameter.Optional }
           );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
               name: "media-index",
               url: "{controller}/{action}/{pageIndex}/{sortBy}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
           );

        }
    }
}
