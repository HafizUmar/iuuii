using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BCharityTHeme.Startup))]
namespace BCharityTHeme
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
