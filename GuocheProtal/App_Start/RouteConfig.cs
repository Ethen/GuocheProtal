using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace GuocheProtal
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("contact", "contact", new { controller = "Home", action = "Contact" });
            routes.MapRoute("join", "join", new { controller = "Home", action = "Join" });
            routes.MapRoute("news", "news", new { controller = "Home", action = "News" });
            routes.MapRoute("product", "product", new { controller = "Home", action = "Product" });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
