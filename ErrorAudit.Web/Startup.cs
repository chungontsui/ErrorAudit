using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ErrorAudit.Web.Startup))]
namespace ErrorAudit.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
