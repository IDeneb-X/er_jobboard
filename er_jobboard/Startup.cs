using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(er_jobboard.Startup))]
namespace er_jobboard
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
