using Hangfire;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopshelfExample.Service
{
    public class HangfireService
    {
        private BackgroundJobServer _server;

        static HangfireService()
        {
            GlobalConfiguration.Configuration
                .UseSqlServerStorage(@"Server=localhost\sqlexpress;Database=TopshelfExample;Trusted_Connection=True;");
        }

        public void Start()
        {
            var options = new BackgroundJobServerOptions();

            _server = new BackgroundJobServer(options);
        }

        public void Stop()
        {
            if(_server != null)
            {
                _server.Dispose();
            }            
        }
    }
}
