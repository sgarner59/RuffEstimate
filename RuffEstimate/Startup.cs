using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RuffEstimate.Startup))]
namespace RuffEstimate
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
