using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Qyteti
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
                name: "QytetetById",
                url: "qytetet/{id}",
                defaults: new { controller = "Qytetet", action = "Index" },
                constraints: new { id = @"\d+" }
            );
            routes.MapRoute(
                name: "QytetetHistory",
                url: "qytetet/history/{id}",
                defaults: new { controller = "Qytetet", action = "History" },
                constraints: new { id = @"\d+" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
