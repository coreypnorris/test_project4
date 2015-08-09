using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PublicComics.Web.Startup))]
namespace PublicComics.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
