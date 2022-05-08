using Owin;
using SelfHost.Console.ConfigurationHellper;
using SelfHost.Console.Contract;
using Owin;
using System.Web.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.Cors;

namespace SelfHost.Console.Implementation
{
    public class StartOption : IStartOption
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new ApiHttpConfiguration();
            config.EnableCors();
            config.EnableCors(new EnableCorsAttribute("*","*","GET , POST , OPTIONS , PUT , DELETE"));
            //app.useCors
            app.UseWebApi(config);
        }
    }
}
