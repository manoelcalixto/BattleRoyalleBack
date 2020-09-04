using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BattleRoyalle.Data
{
    public class DatabaseConnection
    {
        public static IConfiguration ConnectionConfiguration
        {
            get
            {
                IConfigurationRoot Configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build();
                return Configuration;
            }
        }
    }
}
