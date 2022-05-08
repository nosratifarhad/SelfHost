using System.Configuration;

namespace SelfHost.Console.ConfigurationHellper
{
    public class Configuration
    {
        public static string GetDataFromAppSetiongs(string key)
        {
            return ConfigurationSettings.AppSettings.Get(key);
        }
    }
}
