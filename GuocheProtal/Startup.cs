using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GuocheProtal.Startup))]
namespace GuocheProtal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
