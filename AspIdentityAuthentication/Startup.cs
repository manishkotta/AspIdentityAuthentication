using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AspIdentityAuthentication.Startup))]
namespace AspIdentityAuthentication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
