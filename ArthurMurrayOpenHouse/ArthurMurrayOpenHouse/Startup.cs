using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ArthurMurrayOpenHouse.Startup))]
namespace ArthurMurrayOpenHouse
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
