using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ChosenDataTable.Startup))]
namespace ChosenDataTable
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
