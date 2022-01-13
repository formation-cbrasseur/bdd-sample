using BugzillaWebDriver.BaseClasses;
using BugzillaWebDriver.Configuration;
using BugzillaWebDriver.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace BugzillaWebDriver.Tests.ConfigTests
{
    [TestClass]
    public class ConfigTests
    {
        [TestMethod]
        public void GetConfigKeysFromConfigReader()
        {
            IConfig config = new ConfigReader();
            Console.WriteLine("Browser : " + config.GetBrowser());
            Console.WriteLine("Username : " + config.GetUsername());
            Console.WriteLine("Password : " + config.GetPassword());
            Console.WriteLine("Website : " + config.GetWebsite());
        }

        [TestMethod]
        public void GetConfigKeysFromObjectRepository()
        {
            Console.WriteLine("Browser : " + ObjectRepository.Config.GetBrowser());
            Console.WriteLine("Username : " + ObjectRepository.Config.GetUsername());
            Console.WriteLine("Password : " + ObjectRepository.Config.GetPassword());
            Console.WriteLine("Website : " + ObjectRepository.Config.GetWebsite());
        }
    }
}
