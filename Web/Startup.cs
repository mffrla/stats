using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MFFStats.Web.Startup))]
namespace MFFStats.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
