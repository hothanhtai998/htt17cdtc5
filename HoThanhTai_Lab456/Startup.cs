using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HoThanhTai_Lab456.Startup))]
namespace HoThanhTai_Lab456
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
