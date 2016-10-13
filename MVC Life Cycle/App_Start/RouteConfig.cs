using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using MVC_Life_Cycle.Handlers;

namespace MVC_Life_Cycle
{
   public class RouteConfig
   {
      public static void RegisterRoutes(RouteCollection routes)
      {
         //Create your own handler
         //routes.Add(new Route("about/home", new SampleRouteHandler()));

         routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

         //This is an extension method that hides the RouteHandler
         routes.MapRoute(
             name: "Default",
             url: "{controller}/{action}/{id}",
             defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
         );

         //The above extension method does basically this
         //Route myRoute = new Route("{controller}/{action}/{id}",
         //   new RouteValueDictionary {{"controller", "home"}, {"action", "Index"}, {"id", "1"}},
         //   new MvcRouteHandler());

         //routes.Add(myRoute);
      }


      public class SampleRouteHandler : IRouteHandler
      {
         public IHttpHandler GetHttpHandler(RequestContext requestContext)
         {
            return new SampleHandler();
         }
      }


   }
}
