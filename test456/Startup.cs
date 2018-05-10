using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(test456.Startup))]
namespace test456
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
