using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AutoMapper4Demo.Startup))]
namespace AutoMapper4Demo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
