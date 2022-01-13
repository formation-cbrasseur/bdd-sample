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
    public class ButtonTests
    {
        [TestInitialize]
        public void Init()
        {
            NavigationHelper.NavigateToHomePage();
            LinkHelper.ClickLink(By.LinkText("File a Bug"));
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_login"), ObjectRepository.Config.GetUsername());
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_password"), ObjectRepository.Config.GetPassword());
        }

        [TestMethod]
        public void IsButtonEnabledTest()
        {
            ButtonHelper.IsButtonEnabled(By.Id("log_in"));
        }

        [TestMethod]
        public void GetButtonTextTest()
        {
            ButtonHelper.IsButtonEnabled(By.Id("log_in"));
            Console.WriteLine(ButtonHelper.GetButtonText(By.Id("log_in")));
        }

        [TestMethod]
        public void ClickOnLoginTest()
        {
            IWebElement element = GenericHelper.GetElement(By.Id("log_in"));
            element.Click();
            Assert.AreEqual(PageHelper.GetPageTitle(), "Enter Bug: TestProduct");
            NavigationHelper.Logout();
        }

        [TestMethod]
        public void ClickOnLoginFromButtonHelperTest()
        {
            ButtonHelper.ClickButton(By.Id("log_in"));
            Assert.AreEqual(PageHelper.GetPageTitle(), "Enter Bug: TestProduct");
            NavigationHelper.Logout();
        }
    }
}
