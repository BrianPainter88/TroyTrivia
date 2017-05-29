using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(TroyTriviaWeb.Startup))]
namespace TroyTriviaWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
