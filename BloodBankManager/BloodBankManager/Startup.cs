using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BloodBankManager.Startup))]
namespace BloodBankManager
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
