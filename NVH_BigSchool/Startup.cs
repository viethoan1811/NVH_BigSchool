using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NVH_BigSchool.Startup))]
namespace NVH_BigSchool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
