using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCPagina.Startup))]
namespace MVCPagina
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
