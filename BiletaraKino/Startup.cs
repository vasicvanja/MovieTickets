using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BiletaraKino.Startup))]
namespace BiletaraKino
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
