using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JQueryAjaxASP.NETMVC.Startup))]
namespace JQueryAjaxASP.NETMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
