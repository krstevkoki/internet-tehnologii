using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab5MVC.Startup))]
namespace Lab5MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
