using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vanilla_Vivo.Startup))]
namespace Vanilla_Vivo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
