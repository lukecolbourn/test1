using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DeployToAzure.Startup))]
namespace DeployToAzure
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            app.MapSignalR();
        }
    }
}
