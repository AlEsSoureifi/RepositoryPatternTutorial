using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RepositoryPatternTutorial.Startup))]
namespace RepositoryPatternTutorial
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
