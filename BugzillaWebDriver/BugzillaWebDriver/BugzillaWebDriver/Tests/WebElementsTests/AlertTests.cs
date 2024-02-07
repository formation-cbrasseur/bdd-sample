using BugzillaWebDriver.BaseClasses;
using BugzillaWebDriver.ComponentHelper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BugzillaWebDriver.Tests.WebElementsTests
{
    [TestClass]
    public class AlertTests
    {
        [TestInitialize]
        public void Init()
        {
            NavigationHelper.NavigateToHomePage();
            TextBoxHelper.TypeInTextBox(By.Id("login"), ObjectRepository.Config.GetUsername());
            TextBoxHelper.TypeInTextBox(By.Id("password"), ObjectRepository.Config.GetPassword());
            ButtonHelper.ClickButton(By.Name("form"));
            Assert.AreEqual("http://127.0.0.1/portal.php", PageHelper.GetPageUrl());
        }

        [TestMethod]
        public void Accept_OnSimpleAlert_GoesToNextPage()
        {
            LinkHelper.ClickLink(By.LinkText("Logout"));
            AlertHelper.Accept();
            // Needs to wait on this particular project because project is going to portal.php before going to logout.php
            Task.Delay(100).Wait();
            Assert.AreEqual("http://127.0.0.1/login.php", PageHelper.GetPageUrl());
        }

        [TestMethod]
        public void Dismiss_OnSimpleAlert_StayOnSamePage()
        {
            LinkHelper.ClickLink(By.LinkText("Logout"));
            AlertHelper.Dismiss();
            // Needs to wait on this particular project because project is going to portal.php before going to logout.php
            Task.Delay(100).Wait();
            Assert.AreEqual("http://127.0.0.1/portal.php", PageHelper.GetPageUrl());
        }
    }
}
