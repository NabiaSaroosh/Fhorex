using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Fhorex.Startup))]
namespace Fhorex
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
