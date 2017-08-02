using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PackageBD.Startup))]
namespace PackageBD
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
