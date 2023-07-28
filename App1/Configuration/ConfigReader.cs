using App1.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.Configuration
{
    internal class ConfigReader : IConfig
    {
        private GameSettings settings;

        public ConfigReader()
        {
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile(@"C:\Users\ecoki\OneDrive\Bureau\Laaouine Abdellah Apprenti\Workspace\Behavior driven developement TP\APP1\App1\App1\appsettings.json")
                .AddEnvironmentVariables()
                .Build();

            settings = config.GetRequiredSection(nameof(GameSettings)).Get<GameSettings>();
        }

        public BrowserType GetBrowser()
        {
            string browser = settings.Browser;

            try
            {
                return (BrowserType)Enum.Parse(typeof(BrowserType), browser);
            }
            catch (ArgumentException)
            {
                throw new NoSuitableDriverFound("Aucun driver n'a été trouvé  : " + settings.Browser);
            }
        }

        public string GetPlayerOne()
        {
            return settings.PlayerOne;
        }

        public string GetPlayerTwo()
        {
            return settings.PlayerTwo;
        }

        public string GetWebsite()
        {
            return settings.Website;
        }

        /*[...Completez...]*/
    }
}
