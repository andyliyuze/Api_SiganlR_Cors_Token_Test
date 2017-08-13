using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebForPc.Startup))]
namespace WebForPc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
