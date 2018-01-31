using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyFirstWeb.Startup))]
namespace MyFirstWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
