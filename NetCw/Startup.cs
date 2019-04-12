using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NetCw.Startup))]
namespace NetCw
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
