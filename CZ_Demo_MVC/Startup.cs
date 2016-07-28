using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CZ_Demo_MVC.Startup))]
namespace CZ_Demo_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
