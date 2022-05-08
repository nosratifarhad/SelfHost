using System.Web.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace SelfHost.Console.ConfigurationHellper
{
    public class ApiHttpConfiguration : HttpConfiguration
    {
        public ApiHttpConfiguration()
        {
            ConfigureRoutes();
            ConfigureJsonSerialization();

        }
        private void ConfigureRoutes()
        {
            Routes.MapHttpRoute(name: "ApiWithAction", routeTemplate: "api/{controller}/{action}/{id}", defaults: new { RouteParameter.Optional });
            Routes.MapHttpRoute(name: "DefaultApi", routeTemplate: "api/{controller}/{id}", defaults: new { RouteParameter.Optional });
        }

        private void ConfigureJsonSerialization()
        {
            var jsonSettiongs = Formatters.JsonFormatter.SerializerSettings;
            jsonSettiongs.Formatting = Formatting.Indented;
            jsonSettiongs.ContractResolver = new CamelCasePropertyNamesContractResolver();
        }

    }
}
