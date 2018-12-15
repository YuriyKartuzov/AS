using ActorStudio.Models;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ActorStudio.Startup))]
namespace ActorStudio
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {        
            ConfigureAuth(app);
        }
    }
}
