using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using App1.BaseClasses;
using App1.Interfaces;
using App1.Configuration;

namespace WorkshopBDD.Tests.NavigatorTests
{
    [TestClass]
    public class NavigatorTests
    {
        [TestMethod]
        public void OpenChromeAndGoToHomePage()
        {
            IWebDriver driver = new ChromeDriver();
            IConfig config = new ConfigReader();
            //driver.Navigate().GoToUrl(config.GetWebsite());
            driver.Navigate().GoToUrl(ObjectRepository.Config.GetWebsite());
            driver.Close();
            driver.Quit();
        }

        [TestMethod]
        public void OpenFirefoxAndGoToHomePage()
        {
            IWebDriver driver = new FirefoxDriver();
            IConfig config = new ConfigReader();
            //driver.Navigate().GoToUrl(config.GetWebsite());
            driver.Navigate().GoToUrl(ObjectRepository.Config.GetWebsite());
            driver.Close();
            driver.Quit();
        }

        [TestMethod]
        [Ignore]
        public void OpenIEAndGoToHomePage()
        {
            IWebDriver driver = new InternetExplorerDriver();
            IConfig config = new ConfigReader();
            driver.Navigate().GoToUrl(config.GetWebsite());
            //driver.Navigate().GoToUrl(ObjectRepository.Config.GetWebsite());
            driver.Close();
            driver.Quit();
        }


        [TestMethod]
        public void OpenConfigBrowserFromObjectRepositoryAndGoToHomePage()
        {
            ObjectRepository.Driver.Navigate().GoToUrl(ObjectRepository.Config.GetWebsite());
        }

        [TestMethod]
        public void OpenConfigBrowserWithBaseClass()
        {
            Console.WriteLine(ObjectRepository.Config.GetWebsite());
        }
    }
}
