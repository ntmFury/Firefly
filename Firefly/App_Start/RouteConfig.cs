﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Firefly
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            routes.MapRoute(
                name: "Product Category",
                url: "danh-muc/{MetaTitle}-{cateId}",
                defaults: new { controller = "Category", action = "Category", id = UrlParameter.Optional },
                namespaces: new[] { "Firefly.Controllers" }
            );
            routes.MapRoute(
              name: "Product Detail",
              url: "chi-tiet/{MetaTitle}-{id}",
              defaults: new { controller = "Category", action = "Detail", id = UrlParameter.Optional },
              namespaces: new[] { "Firefly.Controllers" }
            );
            routes.MapRoute(
               name: "Default",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
               namespaces: new[] { "Firefly.Controllers" }
           );

        }
    }
}
