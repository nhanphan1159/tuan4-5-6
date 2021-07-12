using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(lab.StartupOwin))]

namespace lab
{
    public partial class StartupOwin
    {
        public void Configuration(IAppBuilder app)
        {
            //AuthStartup.ConfigureAuth(app);
        }
    }
}
