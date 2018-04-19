using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AplicatieSalariati.Startup))]
namespace AplicatieSalariati
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
