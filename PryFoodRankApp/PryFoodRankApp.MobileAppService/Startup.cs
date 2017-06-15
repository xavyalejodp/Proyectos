using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(PryFoodRankApp.MobileAppService.Startup))]

namespace PryFoodRankApp.MobileAppService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}