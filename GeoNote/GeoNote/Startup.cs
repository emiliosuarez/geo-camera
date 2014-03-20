using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GeoNote.Startup))]
namespace GeoNote
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
