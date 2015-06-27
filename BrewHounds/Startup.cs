using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BrewHounds.Startup))]
namespace BrewHounds
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
