using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(test1234.Startup))]
namespace test1234
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
