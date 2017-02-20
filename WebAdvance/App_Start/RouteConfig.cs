using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebAdvance
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Bugs",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Bugs", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Projects",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Projects", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Tester",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Tester", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Login", action = "Index", id = UrlParameter.Optional }
            );

            

            
        }
    }
}
