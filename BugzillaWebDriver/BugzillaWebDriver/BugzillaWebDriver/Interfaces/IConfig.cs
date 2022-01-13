using BugzillaWebDriver.Settings;
using System;
using System.Collections.Generic;
using System.Text;

namespace BugzillaWebDriver.Interfaces
{
    public interface IConfig
    {
        public BrowserType GetBrowser();
        public string GetUsername();
        public string GetPassword();
        public string GetWebsite();
    }
}
