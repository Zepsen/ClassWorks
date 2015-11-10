using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ClassWorks.Startup))]
namespace ClassWorks
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
