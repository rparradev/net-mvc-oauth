using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NET.MVCOAuth.Startup))]
namespace NET.MVCOAuth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
