using BugzillaWebDriver.BaseClasses;
using BugzillaWebDriver.ComponentHelper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace BugzillaWebDriver.Tests.PageNavigationTests
{
    [TestClass]
    public class PageNavigationTests
    {
        [TestMethod]
        public void OpenPageFromDriver()
        {
            ObjectRepository.Driver.Navigate().GoToUrl(ObjectRepository.Config.GetWebsite());
        }

        [TestMethod]
        public void OpenPageFromObjectRepository()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
        }

        [TestMethod]
        public void OpenPageFromObjectRepositoryAndGetTitle()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            Console.WriteLine(ObjectRepository.Driver.Title);
        }

        [TestMethod]
        public void OpenPageFromObjectRepositoryAndGetTitleFromPageHelper()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            Console.WriteLine(PageHelper.GetPageTitle());
        }

        [TestMethod]
        public void ClickOnLoginFromButtonHelperAndCheckPageTitleTest()
        {
            NavigationHelper.NavigateToHomePage();
            LinkHelper.ClickLink(By.LinkText("File a Bug"));
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_login"), ObjectRepository.Config.GetUsername());
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_password"), ObjectRepository.Config.GetPassword());
            ButtonHelper.ClickButton(By.Id("log_in"));
            Assert.AreEqual(PageHelper.GetPageTitle(), "Enter Bug: TestProduct");
            NavigationHelper.NavigateToUrl("http://localhost:5001/index.cgi?logout=1");
        }

        [TestMethod]
        public void ClickOnLoginFromButtonHelperAndCheckPageUrlTest()
        {
            NavigationHelper.NavigateToHomePage();
            LinkHelper.ClickLink(By.LinkText("File a Bug"));
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_login"), ObjectRepository.Config.GetUsername());
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_password"), ObjectRepository.Config.GetPassword());
            ButtonHelper.ClickButton(By.Id("log_in"));
            Assert.AreEqual(PageHelper.GetPageUrl(), "http://localhost:5001/enter_bug.cgi");
            NavigationHelper.NavigateToUrl("http://localhost:5001/index.cgi?logout=1");
        }
    }
}
