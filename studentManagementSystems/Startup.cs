using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(studentManagementSystems.Startup))]
namespace studentManagementSystems
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
