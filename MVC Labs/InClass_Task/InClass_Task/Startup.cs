using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InClass_Task.Startup))]
namespace InClass_Task
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
