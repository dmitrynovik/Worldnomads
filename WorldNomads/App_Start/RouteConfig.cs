using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WorldNomads
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "EnumerateSequences",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "EnumerateSequences", id = UrlParameter.Optional }
            );
        }
    }
}
