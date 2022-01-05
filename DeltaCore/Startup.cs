using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DeltaCore.Startup))]
namespace DeltaCore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
