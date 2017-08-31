using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IITS_Login1.Startup))]
namespace IITS_Login1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
