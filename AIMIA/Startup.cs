using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AIMIA.Startup))]
namespace AIMIA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
