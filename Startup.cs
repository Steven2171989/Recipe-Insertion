using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RecipeWebSite.Startup))]
namespace RecipeWebSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
