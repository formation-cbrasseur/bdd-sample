using BugzillaWebDriver.BaseClasses;
using BugzillaWebDriver.Configuration;
using BugzillaWebDriver.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Text;

namespace BugzillaWebDriver.Tests.NavigatorTests
{
    [TestClass]
    public class NavigatorTests
    {

        [TestMethod]
        [Ignore]
        public void OpenChromeAndGoToHomePage()
        {
            IWebDriver driver = new ChromeDriver();
            IConfig config = new ConfigReader();
            driver.Navigate().GoToUrl(config.GetWebsite());
            //driver.Navigate().GoToUrl(ObjectRepository.Config.GetWebsite());
            driver.Close();
            driver.Quit();
        }

        [TestMethod]
        public void OpenFirefoxAndGoToHomePage()
        {
            IWebDriver driver = new FirefoxDriver();
            IConfig config = new ConfigReader();
            driver.Navigate().GoToUrl(config.GetWebsite());
            //driver.Navigate().GoToUrl(ObjectRepository.Config.GetWebsite());
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
