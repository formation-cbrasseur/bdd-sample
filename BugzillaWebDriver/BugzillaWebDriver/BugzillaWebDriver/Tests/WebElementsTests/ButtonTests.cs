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
            NavigationHelper.Logout();
            NavigationHelper.NavigateToHomePage();
            TextBoxHelper.TypeInTextBox(By.Id("login"), ObjectRepository.Config.GetUsername());
            TextBoxHelper.TypeInTextBox(By.Id("password"), ObjectRepository.Config.GetPassword());
        }

        [TestMethod]
        public void IsButtonEnabled_ForEnabledButton_ReturnsTrue()
        {
            var enabled = ButtonHelper.IsButtonEnabled(By.Name("form"));
            Assert.IsTrue(enabled);
        }

        [TestMethod]
        public void GetButtonText_OnLoginPageButton_ReturnsSubmit()
        {
            ButtonHelper.IsButtonEnabled(By.Name("form"));
            Assert.AreEqual("submit", ButtonHelper.GetButtonText(By.Name("form")));
        }

        [TestMethod]
        public void ClickOnLoginFromWebElement_Click_GoesToPortalPage()
        {
            IWebElement element = GenericHelper.GetElement(By.Name("form"));
            element.Click();
            Assert.AreEqual("bWAPP - Portal", PageHelper.GetPageTitle());
            NavigationHelper.Logout();
        }

        [TestMethod]
        public void ClickOnLoginFromHelper_Click_GoesToPortalPage()
        {
            ButtonHelper.ClickButton(By.Name("form"));
            Assert.AreEqual("bWAPP - Portal", PageHelper.GetPageTitle());
            NavigationHelper.Logout();
        }
    }
}
