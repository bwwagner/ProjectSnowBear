using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using SnowCrashBank.App_Start;

[assembly: OwinStartupAttribute(typeof(SnowCrashBank.Startup))]

namespace SnowCrashBank

{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=316888
            //ConfigureAuth(app);
        }
    }
}
