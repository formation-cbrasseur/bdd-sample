using BugzillaWebDriver.BaseClasses;
using BugzillaWebDriver.ComponentHelper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace BugzillaWebDriver.Tests.WebElementsTests
{
    [TestClass]
    public class HyperLinkTests
    {
        [TestInitialize]
        [Ignore]
        public void Init()
        {
            NavigationHelper.NavigateToHomePage();
        }

        [TestMethod]
        [Ignore]
        public void ClickHyperLinkTest()
        {
            IWebElement element = GenericHelper.GetElement(By.LinkText("File a Bug"));
            element.Click();
        }

        [TestMethod]
        [Ignore]
        public void ClickHyperLinkTestFromLinkHelper()
        {
            LinkHelper.ClickLink(By.LinkText("File a Bug"));
        }
    }
}
