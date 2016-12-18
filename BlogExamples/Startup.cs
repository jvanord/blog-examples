using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BlogExamples.Startup))]
namespace BlogExamples
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
