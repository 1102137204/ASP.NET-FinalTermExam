using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(finalEmployee.Startup))]
namespace finalEmployee
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
