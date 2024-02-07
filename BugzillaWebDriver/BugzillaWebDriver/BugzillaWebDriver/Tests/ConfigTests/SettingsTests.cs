using BugzillaWebDriver.Configuration;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace BugzillaWebDriver.Tests.ConfigTests
{
    [TestClass]
    public class SettingsTests
    {
        private BugzillaSettings settings;

        [TestInitialize]
        public void Init()
        {
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .AddEnvironmentVariables()
                .Build();

            settings = config.GetRequiredSection(nameof(BugzillaSettings)).Get<BugzillaSettings>();
        }

        [TestMethod]
        public void GetBrowserFromConfig()
        {
            Console.WriteLine($"Browser = { settings.Browser }");
        }

        [TestMethod]
        public void GetUsernameFromConfig()
        {
            Console.WriteLine($"Username = { settings.Username }");
        }

        [TestMethod]
        public void GetPasswordFromConfig()
        {
            Console.WriteLine($"Password = { settings.Password }");
        }

        [TestMethod]
        public void GetWebsiteFromConfig()
        {
            Console.WriteLine($"Website = { settings.Website }");
        }
    }
}
