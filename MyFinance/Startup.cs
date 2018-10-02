using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyFinance.Startup))]
namespace MyFinance
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
