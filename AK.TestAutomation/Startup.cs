using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AK.TestAutomation.Startup))]
namespace AK.TestAutomation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
