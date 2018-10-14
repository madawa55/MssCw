using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MssCw.Startup))]
namespace MssCw
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
