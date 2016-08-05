using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FirstAppk.Startup))]
namespace FirstAppk
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
