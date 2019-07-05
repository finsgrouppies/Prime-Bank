using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Burberry.Startup))]
namespace Burberry
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
