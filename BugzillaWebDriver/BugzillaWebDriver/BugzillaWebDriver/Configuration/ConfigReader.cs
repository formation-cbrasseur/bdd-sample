using BugzillaWebDriver.CustomExceptions;
using BugzillaWebDriver.Interfaces;
using BugzillaWebDriver.Settings;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace BugzillaWebDriver.Configuration
{
    public class ConfigReader : IConfig
    {

        private BugzillaSettings settings;

        public ConfigReader()
        {
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .AddEnvironmentVariables()
                .Build();

            settings = config.GetRequiredSection(nameof(BugzillaSettings)).Get<BugzillaSettings>();
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

        public string GetUsername()
        {
            return settings.Username;
        }

        public string GetPassword()
        {
            return settings.Password;
        }

        public string GetWebsite()
        {
            return settings.Website;
        }
    }
}
