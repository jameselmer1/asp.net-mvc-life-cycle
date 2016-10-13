using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;


namespace MVC_Life_Cycle.Configuration
{
   public class RedirectModule : IHttpModule
   {
      private HttpApplication _context;

      public void Init(HttpApplication context)
      {
         _context = context;
         _context.MapRequestHandler += RedirectUrls;

      }

      public void RedirectUrls(object src, EventArgs args)
      {
         RedirectSection section = (RedirectSection) WebConfigurationManager.GetSection("redirects");
         foreach (Redirect redirect in section.Redirects)
         {
            if (redirect.Old == _context.Request.RequestContext.HttpContext.Request.RawUrl)
            {
               _context.Response.Redirect(redirect.New);
            }
         }
      }

      public void Dispose()
      {
         //no resources to dispose of
      }
   }
}