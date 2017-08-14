using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using System.Web.Http;
using System.Web.Http.Cors;
[assembly: OwinStartup(typeof(webApiToken.Startup))]

namespace webApiToken
{
    public class Startup
    {
        public static void Configuration(IAppBuilder appBuilder)
        {
            
            // 有关如何配置应用程序的详细信息，请访问 http://go.microsoft.com/fwlink/?LinkID=316888
            // Configure Web API for Self-Host
            HttpConfiguration config = new HttpConfiguration();
            //跨域配置
            config.EnableCors(new EnableCorsAttribute("*", "*", "*"));
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            appBuilder.UseWebApi(config);
        }
    }
}
