using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mvc5a.Startup))]
namespace mvc5a
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
