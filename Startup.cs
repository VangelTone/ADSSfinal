using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Library_4659.Startup))]
namespace Library_4659
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
