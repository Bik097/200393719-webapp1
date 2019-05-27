using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_200393719_webapp1.Startup))]
namespace _200393719_webapp1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
