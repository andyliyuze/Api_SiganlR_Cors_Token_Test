using Microsoft.Owin;
using Owin;
using Microsoft.Owin.Cors;
using Microsoft.AspNet.SignalR;
 
namespace SignalRService
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            
            app.UseCors(CorsOptions.AllowAll);
            app.MapSignalR( );
        }
    }
}
