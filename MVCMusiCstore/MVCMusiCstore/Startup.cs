using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCMusiCstore.Startup))]
namespace MVCMusiCstore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
