using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CF_GitExample_Neo.Startup))]
namespace CF_GitExample_Neo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
