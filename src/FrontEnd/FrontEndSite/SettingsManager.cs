using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace FrontEndSite
{
    public class SettingsManager
    {
#region Singleton
        public static SettingsManager Instance;

        static SettingsManager()
        {
            Instance = new SettingsManager();
        }
#endregion 

        public string BackEndUrl { get; private set; }

        private SettingsManager()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            IConfiguration configurations = builder.Build();
            BackEndUrl = configurations["BackEndUrl"];
        }
    }
}
