using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Life_Cycle.Handlers
{
   public class SampleHandler : IHttpHandler
   {
      public void ProcessRequest(HttpContext context)
      {
         context.Response.Write("<p>Custom Handler</p>");
      }

      public bool IsReusable => false;
   }
}