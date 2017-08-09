using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(assign1task3.Startup))]
namespace assign1task3
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
