using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HalpBarter.Startup))]
namespace HalpBarter
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
