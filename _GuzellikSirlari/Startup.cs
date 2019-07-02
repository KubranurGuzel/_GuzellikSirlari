using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_GuzellikSirlari.Startup))]
namespace _GuzellikSirlari
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }
}
