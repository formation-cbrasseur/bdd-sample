using BugzillaWebDriver.Interfaces;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace BugzillaWebDriver.BaseClasses
{
    public class ObjectRepository
    {
        public static IConfig Config { get; set; }
        public static IWebDriver Driver { get; set; }
    }
}
