using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GradFIlmaProjekat.Startup))]
namespace GradFIlmaProjekat
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
