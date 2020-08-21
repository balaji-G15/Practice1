using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Practice1GitHub.Startup))]
namespace Practice1GitHub
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
