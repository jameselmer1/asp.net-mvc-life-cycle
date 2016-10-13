using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace MVC_Life_Cycle
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

      protected void Application_BeginRequest()
      {
         Debug.WriteLine("Begin Request");
      }

      protected void Application_MapRequestHandler()
      {
         Debug.WriteLine("Map Request Handler");
      }

      protected void Application_PostMapRequestHandler()
      {
         Debug.WriteLine("Post Map Request Handler");
      }

      protected void Application_AcquireRequestState()
      {
         Debug.WriteLine("Acquire Request State");
      }

      protected void Application_PreRequestHandlerExecute()
      {
         Debug.WriteLine("Pre Request Handler Execute");
      }

      protected void Application_PostRequestHandlerExecute()
      {
         Debug.WriteLine("Post Request Handler Execute");
      }

      protected void Application_EndRequest()
      {
         Debug.WriteLine("End Request");
      }
   }
}
