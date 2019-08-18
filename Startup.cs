using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AWSSimpleApplication.Startup))]
namespace AWSSimpleApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
