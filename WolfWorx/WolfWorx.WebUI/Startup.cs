using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WolfWorx.WebUI.Startup))]
namespace WolfWorx.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
