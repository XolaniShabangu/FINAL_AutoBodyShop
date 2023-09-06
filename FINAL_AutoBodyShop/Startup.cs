using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FINAL_AutoBodyShop.Startup))]
namespace FINAL_AutoBodyShop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
