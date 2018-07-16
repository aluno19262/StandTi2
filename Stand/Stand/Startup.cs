using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Stand.Startup))]
namespace Stand
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
