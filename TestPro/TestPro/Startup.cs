using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestPro.Startup))]
namespace TestPro
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
