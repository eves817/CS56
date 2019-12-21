using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CS56_.Startup))]
namespace CS56_
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
