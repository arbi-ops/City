using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Qyteti.Startup))]
namespace Qyteti
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
