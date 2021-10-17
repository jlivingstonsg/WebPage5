using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebPage5.Startup))]
namespace WebPage5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
