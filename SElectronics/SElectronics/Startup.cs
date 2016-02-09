using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SElectronics.Startup))]
namespace SElectronics
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
