using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcAppAuth.Startup))]
namespace MvcAppAuth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
