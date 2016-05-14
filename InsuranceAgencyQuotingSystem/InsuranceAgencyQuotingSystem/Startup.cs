using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InsuranceAgencyQuotingSystem.Startup))]
namespace InsuranceAgencyQuotingSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
