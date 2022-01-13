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
        public void Init()
        {
            NavigationHelper.NavigateToHomePage();
        }

        [TestMethod]
        public void ClickHyperLinkTest()
        {
            IWebElement element = GenericHelper.GetElement(By.LinkText("File a Bug"));
            element.Click();
        }

        [TestMethod]
        public void ClickHyperLinkTestFromLinkHelper()
        {
            LinkHelper.ClickLink(By.LinkText("File a Bug"));
        }
    }
}
