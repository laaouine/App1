using App1.BaseClasses;
using App1.Configuration;
using App1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.Tests.ConfigTests
{
    [TestClass]
    public class ConfigReaderTests
    {

        [TestMethod]
        public void GetSettingsKeysFromConfigReader()
        {
            IConfig config = new ConfigReader();
            Console.WriteLine("Browser : " + config.GetBrowser());
            Console.WriteLine("Username : " + config.GetPlayerOne());
            Console.WriteLine("Password : " + config.GetPlayerTwo());
            Console.WriteLine("Website : " + config.GetWebsite());
        }

        [TestMethod]
        public void GetConfigKeysFromObjectRepository()
        {
            Console.WriteLine("Browser : " + ObjectRepository.Config.GetBrowser());
            Console.WriteLine("PlayerOne : " + ObjectRepository.Config.GetPlayerOne());
            Console.WriteLine("PlayerTwo : " + ObjectRepository.Config.GetPlayerTwo());
            Console.WriteLine("Website : " + ObjectRepository.Config.GetWebsite());
        }

    }
}
