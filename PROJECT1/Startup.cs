using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PROJECT1.Startup))]
namespace PROJECT1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
