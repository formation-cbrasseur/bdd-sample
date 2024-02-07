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
    public class TextBoxTests
    {
        [TestInitialize]
        [Ignore]
        public void Init()
        {
            NavigationHelper.NavigateToHomePage();
            LinkHelper.ClickLink(By.LinkText("File a Bug"));
        }

        [TestMethod]
        [Ignore]
        public void TextBoxTest()
        {
            IWebElement element = GenericHelper.GetElement(By.Id("Bugzilla_login"));
            element.SendKeys(ObjectRepository.Config.GetUsername());
            element = GenericHelper.GetElement(By.Id("Bugzilla_password"));
            element.SendKeys(ObjectRepository.Config.GetPassword());
        }

        [TestMethod]
        [Ignore]
        public void TextBoxFromHelperTest()
        {
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_login"), ObjectRepository.Config.GetUsername());
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_password"), ObjectRepository.Config.GetPassword());
        }

        [TestMethod]
        [Ignore]
        public void ClearTextBoxTest()
        {
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_login"), ObjectRepository.Config.GetUsername());
            TextBoxHelper.ClearTextBox(By.Id("Bugzilla_login"));
        }
    }
}
