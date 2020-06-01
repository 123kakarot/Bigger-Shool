using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BTTuan4.Startup))]
namespace BTTuan4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
