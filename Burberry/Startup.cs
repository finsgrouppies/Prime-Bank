using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PrimeBank.Startup))]
namespace PrimeBank
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
