using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KB.Startup))]
namespace KB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
