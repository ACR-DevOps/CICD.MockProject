using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Web.Website.One.Startup))]
namespace Web.Website.One
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
