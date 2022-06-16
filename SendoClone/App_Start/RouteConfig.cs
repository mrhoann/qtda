using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SendoClone
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Sendo", action = "Home", id = UrlParameter.Optional }
            );
            routes.MapRoute(
            name: "Cart",
            url: "{controller}/{action}/{id}/{Quantity}",
            defaults: new { controller = "Sendo", action = " myAddToCart", id = UrlParameter.Optional }
        );

            routes.MapRoute(
            name: "updateCart",
            url: "{controller}/{action}/{id}/{quantity}/{d}",
            defaults: new { controller = "MyShop", action = "updateMyCart", id = UrlParameter.Optional }
        );
          
        }
    }
}
