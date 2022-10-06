using System;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace JsonConfigOnConsoleAppPoc
{
    internal class Program
    {
        
        private const string settingsFileName = "appsettings.json";
        private static DesserializedConfig _config;

        static void Main(string[] args)
        {
            var configBuilder = new ConfigurationBuilder()
                                        .SetBasePath(Directory.GetCurrentDirectory())
                                        .AddJsonFile(settingsFileName);

            _config = configBuilder.Build().GetSection("settings").Get<DesserializedConfig>();

            Console.Write(_config);
        }
    }
}
