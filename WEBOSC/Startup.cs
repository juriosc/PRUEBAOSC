using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WEBOSC.Startup))]
namespace WEBOSC
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
