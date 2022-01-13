using BugzillaWebDriver.BaseClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace BugzillaWebDriver.ComponentHelper
{
    public class NavigationHelper
    {
        public static void NavigateToUrl(string url)
        {
            ObjectRepository.Driver.Navigate().GoToUrl(url);
        }

        public static void NavigateToHomePage()
        {
            ObjectRepository.Driver.Navigate().GoToUrl(ObjectRepository.Config.GetWebsite());
        }

        public static void Logout()
        {
            // TODO: Check if user is logged in
            ObjectRepository.Driver.Navigate().GoToUrl("http://localhost:5001/index.cgi?logout=1");
        }
    }
}
