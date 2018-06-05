using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab26_LogIn.Startup))]
namespace Lab26_LogIn
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
