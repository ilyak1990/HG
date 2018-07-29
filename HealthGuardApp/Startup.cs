using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HealthGuardApp.Startup))]
namespace HealthGuardApp
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
