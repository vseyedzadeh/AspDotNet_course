﻿using System;
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

            routes.MapMvcAttributeRoutes();

            routes.MapRoute(
               name: "Default",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
           );
            /*
            routes.MapRoute(
               name: "Default-test",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Test", action = "getString", id = UrlParameter.Optional }
           );

           

            routes.MapRoute(
               name: "media-index",
               url: "Medias/Index/{pageIndex}/{sortBy}",
               defaults: new { controller = "Medias", action = "Index", id = UrlParameter.Optional }
           );

            routes.MapRoute(
               name: "media-released",
               url: "Medias/released/{year}/{month}",
               defaults: new { controller = "Medias", action = "released", id = UrlParameter.Optional },
               constraints: new { year = @"^(19|20)\d{2}$", month= @"0[1-9]|1[0-2]" }
           );
           */

        }
    }
}
