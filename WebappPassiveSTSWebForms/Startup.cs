using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebappPassiveSTSWebForms.Startup))]
namespace WebappPassiveSTSWebForms
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
