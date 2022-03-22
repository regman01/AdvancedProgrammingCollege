using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AdvancedProgrammingProject2.Startup))]
namespace AdvancedProgrammingProject2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
