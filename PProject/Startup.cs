using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PProject.Startup))]
namespace PProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
