using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WhereAreYou.Startup))]
namespace WhereAreYou
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
