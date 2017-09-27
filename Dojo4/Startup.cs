using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Dojo4.Startup))]
namespace Dojo4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
