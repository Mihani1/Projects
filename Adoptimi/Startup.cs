using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Adoptimi.Startup))]
namespace Adoptimi
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
