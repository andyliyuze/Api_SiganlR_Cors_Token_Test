using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;
using Microsoft.AspNet.SignalR;
using System.Web.Routing;
using Microsoft.Owin.Cors;

[assembly: OwinStartup(typeof(WebApiSignalR.Startup))]

namespace WebApiSignalR
{
    public partial class Startup
    {
        public static void Configuration(IAppBuilder app)
        {
            


            app.UseCors(CorsOptions.AllowAll);
           
            app.MapSignalR();
        }
    }
}
