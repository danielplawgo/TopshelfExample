using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topshelf;

namespace TopshelfExample.Service
{
    class Program
    {
        static void Main(string[] args)
        {
            HostFactory.Run(x =>
            {
                x.UseNLog();

                x.Service<HangfireService>(h =>
                {
                    h.ConstructUsing(n => new HangfireService());
                    h.WhenStarted(s => s.Start());
                    h.WhenStopped(s => s.Stop());
                });

                x.RunAsLocalSystem();

                x.SetDescription("Hangfire Service");
                x.SetDisplayName("Hangfire Service");
                x.SetServiceName("Hangfire Service");
            });
        }
    }
}
