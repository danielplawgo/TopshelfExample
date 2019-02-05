using System;
using System.Threading.Tasks;
using Hangfire;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(TopshelfExample.Web.Startup))]

namespace TopshelfExample.Web
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            GlobalConfiguration.Configuration
                .UseSqlServerStorage(@"Server=localhost\sqlexpress;Database=TopshelfExample;Trusted_Connection=True;");

            app.UseHangfireDashboard();
        }
    }
}
