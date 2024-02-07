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
            TextBoxHelper.TypeInTextBox(By.Id("login"), ObjectRepository.Config.GetUsername());
            TextBoxHelper.TypeInTextBox(By.Id("password"), ObjectRepository.Config.GetPassword());
        }

        [TestMethod]
        public void IsButtonEnabledTest()
        {
            ButtonHelper.IsButtonEnabled(By.Name("form"));
        }

        [TestMethod]
        public void GetButtonTextTest()
        {
            ButtonHelper.IsButtonEnabled(By.Name("form"));
            Console.WriteLine();
            Assert.AreEqual("submit", ButtonHelper.GetButtonText(By.Name("form")));
        }

        [TestMethod]
        public void ClickOnLoginTest()
        {
            IWebElement element = GenericHelper.GetElement(By.Name("form"));
            element.Click();
            Assert.AreEqual(PageHelper.GetPageTitle(), "bWAPP - Portal");
            NavigationHelper.Logout();
        }

        [TestMethod]
        public void ClickOnLoginFromButtonHelperTest()
        {
            ButtonHelper.ClickButton(By.Name("form"));
            Assert.AreEqual(PageHelper.GetPageTitle(), "bWAPP - Portal");
            NavigationHelper.Logout();
        }
    }
}
