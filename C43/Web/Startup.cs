using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(C43Solution.Web.Startup))]
namespace C43Solution.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
