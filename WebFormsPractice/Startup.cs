using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebFormsPractice.Startup))]
namespace WebFormsPractice
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
