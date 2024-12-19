using Microsoft.Owin;
using Owin;
using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidateLog
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HubConfiguration
            {
                EnableDetailedErrors = true
            };

            app.MapSignalR("/signalr", config);
        }
    }
}
