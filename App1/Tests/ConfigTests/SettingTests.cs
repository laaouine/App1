
using App1.Configuration;
using Microsoft.Extensions.Configuration;

namespace App1.Tests.ConfigTests
{
    [TestClass]
    public class SettingTests
    {
        private GameSettings settings;

        [TestInitialize]
        public void Init()
        {
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile(@"C:\Users\ecoki\OneDrive\Bureau\Laaouine Abdellah Apprenti\Workspace\Behavior driven developement TP\APP1\App1\App1\appsettings.json")
                .AddEnvironmentVariables()
                .Build();

            settings = config.GetRequiredSection(nameof(GameSettings)).Get<GameSettings>();
        }

        [TestMethod]
        public void GetBrowserFromConfig()
        {
            Console.WriteLine($"Browser = {settings.Browser}");
        }

        [TestMethod]
        public void GetPlayerOneFromConfig()
        {
            Console.WriteLine($"PlayerOne = {settings.PlayerOne}");
        }

        [TestMethod]
        public void GetPlayerTwoFromConfig()
        {
            Console.WriteLine($"PlayerTwo = {settings.PlayerTwo}");
        }

        [TestMethod]
        public void GetWebsiteFromConfig()
        {
            Console.WriteLine($"Website = {settings.Website}");
        }

    }
}
