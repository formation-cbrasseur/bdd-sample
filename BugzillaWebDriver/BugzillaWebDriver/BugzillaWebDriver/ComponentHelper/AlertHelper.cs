using BugzillaWebDriver.BaseClasses;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BugzillaWebDriver.ComponentHelper
{
    public class AlertHelper
    {
        public static void Accept()
        {
            IAlert alert = ObjectRepository.Driver.SwitchTo().Alert();
            alert.Accept();
        }

        public static void Dismiss()
        {
            IAlert alert = ObjectRepository.Driver.SwitchTo().Alert();
            alert.Dismiss();
        }
    }
}
