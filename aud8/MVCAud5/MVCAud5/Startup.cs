using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCAud5.Startup))]
namespace MVCAud5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
