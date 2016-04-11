using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StatementsAndLoops.Startup))]
namespace StatementsAndLoops
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
